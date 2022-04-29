using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IJobListService
    {
        IDataResult<List<JobList>> GetAll();
        IDataResult<List<JobList>> GetByJobListName(string jobListName);
        IDataResult<JobList> GetById(int jobListId);
        IResult Add(JobList jobList);
        IResult Delete(JobList jobList);
        IResult Update(JobList jobList);
        IResult AddTransactionalTest(JobList jobList);

    }
}
