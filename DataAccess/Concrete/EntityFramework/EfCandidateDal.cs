using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCandidateDal : EfEntityRepositoryBase<Candidate, HrmsContext>, ICandidateDal
    {
        public List<CandidateDetailDto> GetJobListDetails()
        {
            using (HrmsContext context = new HrmsContext())
            {
                var result = from c in context.Candidates
                             join u in context.Users
                             on c.CandidateId equals u.UserId
                             select new CandidateDetailDto { CandidateId = c.CandidateId,FirstName = c.FirstName,
                             LastName = c.LastName, DateOfBirth = c.DateOfBirth, IdentityNumber = c.IdentityNumber};
                return result.ToList();
            }
        }
    }
}
