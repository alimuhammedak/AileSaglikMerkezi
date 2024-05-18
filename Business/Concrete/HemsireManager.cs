using Business.Abstract;
using Core.Utilities.Result;
using Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    internal class HemsireManager : IHemsireService
    {
        public IResult Add(Hemsire Hemsire)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Hemsire Hemsire)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Hemsire>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<Hemsire> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Hemsire Hemsire)
        {
            throw new NotImplementedException();
        }
    }
}
