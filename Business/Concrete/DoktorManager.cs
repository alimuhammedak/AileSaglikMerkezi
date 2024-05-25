using Business.Abstract;
using Business.Constans;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.DTOs;
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
            var result = _doktorDal.GetAll();
            if (result == null)
            {
                return new ErrorDataResult<List<Doktor>>(Messages.DoktorNotFound);
            }
            return new SuccessDataResult<List<Doktor>>(result);
        }

        public IDataResult<List<DoktorDto>> GetAllKayit()
        {
            var result = _doktorDal.GetAllDoktorListe();
            if (result == null)
            {
                return new ErrorDataResult<List<DoktorDto>>(Messages.DoktorNotFound);
            }
            return new SuccessDataResult<List<DoktorDto>>(result);
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
