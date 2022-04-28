using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCandidateDal 
    {
        List<Candidate> _candidates;
        public InMemoryCandidateDal()
        {
            _candidates = new List<Candidate> {
            new Candidate
            {
                CandidateId = 1,
                DateOfBirth = "21.11.1997",
                FirstName = "Sayat",
                LastName ="Kasım",
                IdentityNumber="12345678910",
                
            }
         
            };
        }
        public void Add(Candidate candidate)
        {
            _candidates.Add(candidate);
        }

        public void Delete(Candidate candidate)
        {
            Candidate candidateToDelete = _candidates.SingleOrDefault(c => c.CandidateId == candidate.CandidateId);
            _candidates.Remove(candidateToDelete);
        }

        public Candidate Get(Expression<Func<Candidate, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Candidate> GetAll()
        {
            return _candidates;
        }

        public List<Candidate> GetAll(Expression<Func<Candidate, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Candidate> GetAllByFirstName(string firstName)
        {
            return _candidates.Where(c => c.FirstName == firstName).ToList();
        }

        public void Update(Candidate candidate)
        {
            Candidate candidateToUpdate = _candidates.SingleOrDefault(c => c.CandidateId == candidate.CandidateId);
            candidateToUpdate.FirstName = candidate.FirstName;
            candidateToUpdate.LastName = candidate.LastName;
        }
    }
}
