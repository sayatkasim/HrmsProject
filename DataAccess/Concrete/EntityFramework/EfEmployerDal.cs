using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfEmployerDal : IEmployerDal
    {
        public void Add(Employer entity)
        {

        }

        public void Delete(Employer entity)
        {
            throw new NotImplementedException();
        }

        public Employer Get(Expression<Func<Employer, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Employer> GetAll(Expression<Func<Employer, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Employer entity)
        {
            throw new NotImplementedException();
        }
    }
}
