using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfSikayetTur : EfEntityRepositoryBase<Sikayet, SODBContext>, ISikayetTurDal
    {
        public void Add(SikayetTur entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(SikayetTur entity)
        {
            throw new NotImplementedException();
        }

        public SikayetTur Get(Expression<Func<SikayetTur, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<SikayetTur> GetAll(Expression<Func<SikayetTur, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(SikayetTur entity)
        {
            throw new NotImplementedException();
        }
    }
}
