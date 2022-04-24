using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICandidateService
    {
        IDataResult<List<Candidate>> GetAll();
        IDataResult<List<Candidate>> GetByFirstName(string firstName);
        IDataResult<List<CandidateDetailDto>> GetJobListDetails();
        IResult Add(Candidate candidate);
        IResult Update(Candidate candidate);
        IResult Delete(Candidate candidate);

    }
}
