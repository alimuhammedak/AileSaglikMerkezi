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
    public class ResimYolManager : IResimYolService
    {
        private readonly IResimYolDal _resimYolDal;

        public ResimYolManager(IResimYolDal resimYolDal)
        {
            _resimYolDal = resimYolDal;
        }

        public IResult Add(ResimYolu resimYolu)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(ResimYolu resimYolu)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<ResimYolu>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<ResimYolu> GetByKullaniciID(int id)
        {
            var result = _resimYolDal.Get(x => x.kullaniciID == id);
            if (result == null)
            {
                return new ErrorDataResult<ResimYolu>(Messages.ResimYolNotFound);
            }
            return new SuccessDataResult<ResimYolu>(result);
        }

        public IDataResult<ResimYolu> GetByHastaID(int id)
        {
            var result = _resimYolDal.Get(x => x.hastaID == id);
            if (result == null)
            {
                return new ErrorDataResult<ResimYolu>(Messages.ResimYolNotFound);
            }
            return new SuccessDataResult<ResimYolu>(result);
        }

        public IDataResult<ResimYolu> GetById(int id)
        {
            var result = _resimYolDal.Get(x => x.resimYoluID == id);
            if (result == null)
            {
                return new ErrorDataResult<ResimYolu>(Messages.ResimYolNotFound);
            }
            return new SuccessDataResult<ResimYolu>(result);
        }

        public IResult Update(ResimYolu resimYolu)
        {
            throw new NotImplementedException();
        }
    }
}
