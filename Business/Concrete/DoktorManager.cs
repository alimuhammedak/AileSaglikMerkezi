using Business.Abstract;
using Business.Constans;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class DoktorManager : IDoktorService
    {
        private readonly IDoktorDal _doktorDal;

        public DoktorManager(IDoktorDal doktorDal)
        {
            _doktorDal = doktorDal;
        }

        public IResult Add(Doktor doktor)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Doktor doktor)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Doktor>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<Doktor> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Doktor> GetByKullaniciId(int id)
        {
            var result = _doktorDal.Get(d => d.kullaniciID == id);
            if (result == null)
            {
                return new ErrorDataResult<Doktor>(Messages.DoktorNotFound);
            }
            return new SuccessDataResult<Doktor>(result);
        }

        public IResult Update(Doktor doktor)
        {
            throw new NotImplementedException();
        }
    }
}
