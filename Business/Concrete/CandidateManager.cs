using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CandidateManager : ICandidateService
    {
        ICandidateDal _candidateDal;

        public CandidateManager(ICandidateDal candidateDal)
        {
            _candidateDal = candidateDal;
        }

        public IResult Add(Candidate candidate)
        {
            _candidateDal.Add(candidate);
            return new SuccessResult();
        }

        public IResult Delete(Candidate candidate)
        {
           _candidateDal.Delete(candidate);
            return new SuccessResult();
        }

        public IDataResult<List<Candidate>> GetAll()
        {
            return new SuccessDataResult<List<Candidate>>(_candidateDal.GetAll(),Messages.CandidateListed);
        }

        public IDataResult<List<Candidate>> GetByFirstName(string firstName)
        {
            return new SuccessDataResult<List<Candidate>>(_candidateDal.GetAll(c=> c.FirstName == firstName),Messages.CandidateListed);
        }

        public IDataResult<List<CandidateDetailDto>> GetJobListDetails()
        {
            return new SuccessDataResult<List<CandidateDetailDto>>(_candidateDal.GetJobListDetails(),Messages.CandidateListed);
        }

        public IResult Update(Candidate candidate)
        {
            _candidateDal.Update(candidate);
            return new SuccessResult();
        }
    }
}
