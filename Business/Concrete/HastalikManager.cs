using Business.Abstract;
using Business.Constans;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Business.Concrete
{
    public class HastalikManager : IHastalikService
    {
        private readonly IHastalikDal _hastalikDal;

        public HastalikManager(IHastalikDal hastalikDal)
        {
            _hastalikDal = hastalikDal;
        }

        public IResult Add(Hastalik hastalik)
        {
            _hastalikDal.Add(hastalik);
            return new SuccessResult(Messages.HastalikAdded);
        }

        public IResult Delete(Hastalik hastalik)
        {
           _hastalikDal.Delete(hastalik);
            return new SuccessResult(Messages.HastalikDeleted);
        }

        public IDataResult<List<Hastalik>> GetAll()
        {
            var result = _hastalikDal.GetAll();
            if (result is null)
            {
                return new ErrorDataResult<List<Hastalik>>(Messages.HastalikNotFound);
            }
            return new SuccessDataResult<List<Hastalik>>(result, Messages.HastalikListed);
        }

        public IDataResult<Hastalik> GetById(int id)
        {
            var result = _hastalikDal.Get(h => h.hastalikID == id);
            if (result is null)
            {
                return new ErrorDataResult<Hastalik>(Messages.HastalikNotFound);
            }
            return new SuccessDataResult<Hastalik>(result, Messages.HastalikFound);
        }

        public IResult Update(Hastalik hastalik)
        {
            _hastalikDal.Update(hastalik);
            return new SuccessResult(Messages.HastalikUpdated);
        }
    }
}
