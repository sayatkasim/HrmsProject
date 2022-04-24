﻿using Business.Abstract;
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

namespace Business.Concrete
{
    public class JobListManager : IJobListService
    {
        IJobListDal _jobListDal;

        public JobListManager(IJobListDal jobListDal)
        {
            _jobListDal = jobListDal;
        }

        [ValidationAspect(typeof(JobListValidator))]
        public IResult Add(JobList jobList)
        {
           
            _jobListDal.Add(jobList);
            return new SuccessResult(Messages.JobListAdded);
        }

        public IResult Delete(JobList jobList)
        {
            _jobListDal.Delete(jobList);
            return new SuccessResult();
        }

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

        public IResult Update(JobList jobList)
        {
            _jobListDal.Update(jobList);
            return new SuccessResult();
        }
    }
}
