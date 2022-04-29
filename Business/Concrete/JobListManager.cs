using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofact.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.BusinessAspects.Autofac;
using Core.Aspects.Autofact.Caching;
using Core.Aspects.Autofact.Perofrmance;
using Core.Aspects.Autofact.Transaction;
using Core.Utilities.Business;
using Microsoft.AspNetCore.Components.RenderTree;

namespace Business.Concrete
{
    public class JobListManager : IJobListService
    {
        IJobListDal _jobListDal;

        public JobListManager(IJobListDal jobListDal)
        {
            _jobListDal = jobListDal;
        }

        
        [SecuredOperation("joblist.add,admin")]
        [ValidationAspect(typeof(JobListValidator))]
        [CacheRemoveAspect("IJobListService.Get")]
        public IResult Add(JobList jobList)
        {
           IResult result = BusinessRules.Run(
                CheckIfJobNameExists(jobList.JobListName));

           if (result != null)
           {
               return result;
           }
            
           _jobListDal.Add(jobList);
           return new SuccessResult(Messages.JobListAdded);

        }

        [CacheRemoveAspect("IJobListService.Get")]
        public IResult Delete(JobList jobList)
        {
            _jobListDal.Delete(jobList);
            return new SuccessResult();
        }

        [CacheAspect]
        [PerformanceAspect(5)]
        public IDataResult<List<JobList>> GetAll()
        {

            return new SuccessDataResult<List<JobList>>(_jobListDal.GetAll(), Messages.JobListListed);
        }

        public IDataResult<JobList> GetById(int jobListId)
        {
            return new SuccessDataResult<JobList>(_jobListDal.Get(j => j.JobListId == jobListId), Messages.JobListListed);
        }

        public IDataResult<List<JobList>> GetByJobListName(string jobListName)
        {
            return new SuccessDataResult<List<JobList>>(_jobListDal.GetAll(j => j.JobListName == jobListName), Messages.JobListListed);
        }
        
        [ValidationAspect(typeof(JobListValidator))]
        [CacheRemoveAspect("IJobListService.Get")]
        public IResult Update(JobList jobList)
        {
            _jobListDal.Update(jobList);
            return new SuccessResult();
        }

        [TransactionScopeAspect]
        public IResult AddTransactionalTest(JobList jobList)
        {
            
            Add(jobList);
            if (jobList.JobListName == "Deneme")
            {
                throw new Exception("");
            }

            Add(jobList);
            return null;
        }

        private IResult CheckIfJobNameExists(string jobListname)
        {
            var result = _jobListDal.GetAll(j => j.JobListName == jobListname).Any();
            if (result)
            {
                return new ErrorResult(Messages.JobListAllreadyExists);
            }

            return new SuccessResult();
        }
    }
}
