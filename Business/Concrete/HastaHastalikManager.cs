using Business.Abstract;
using Business.Constans;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Entity;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class HastaHastalikManager : IHastaHastalikService
    {
        private readonly IHastaHastalikDal _hastaHastalikDal;

        public HastaHastalikManager(IHastaHastalikDal hastaHastalikDal)
        {
            _hastaHastalikDal = hastaHastalikDal;
        }

        public IResult Add(HastaHastalik hastaHastalik)
        {
            _hastaHastalikDal.Add(hastaHastalik);
            return new SuccessResult(Messages.HastaHastalikAdded);
        }

        public IResult Delete(HastaHastalik hastaHastalik)
        {
            _hastaHastalikDal.Delete(hastaHastalik);
            return new SuccessResult(Messages.HastaHastalikDeleted);
        }

        public IDataResult<List<HastaHastalik>> GetAll()
        {
            var result = _hastaHastalikDal.GetAll();
            return new SuccessDataResult<List<HastaHastalik>>(result, Messages.HastaHastalikListed);
        }

        public IDataResult<HastaHastalik> GetById(int id)
        {
            var result = _hastaHastalikDal.Get(h => h.hastaHastalikID == id);
            if (result == null)
            {
                return new ErrorDataResult<HastaHastalik>(Messages.HastaHastalikNotFound);
            }
            return new SuccessDataResult<HastaHastalik>(result, Messages.HastaHastalikFound);
        }

        public IResult Update(HastaHastalik hastaHastalik)
        {
            _hastaHastalikDal.Update(hastaHastalik);
            return new SuccessResult(Messages.HastaHastalikUpdated);
        }
    }
}
