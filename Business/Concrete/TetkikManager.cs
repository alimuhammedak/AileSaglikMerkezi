using Business.Abstract;
using Business.Constans;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Entity;
using System;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class TetkikManager : ITetkikService
    {
        private readonly ITetkikDal _tetkikDal;

        public TetkikManager(ITetkikDal tetkikDal)
        {
            _tetkikDal = tetkikDal;
        }

        public IResult Add(Tetkik tetkik)
        {
            _tetkikDal.Add(tetkik);
            return new SuccessResult(Messages.TetkikAdded);
        }

        public IResult Delete(Tetkik tetkik)
        {
            _tetkikDal.Delete(tetkik);
            return new SuccessResult(Messages.TetkikDeleted);
        }

        public IDataResult<List<Tetkik>> GetAll()
        {
            var result = _tetkikDal.GetAll();
            if (result is null)
            {
                return new ErrorDataResult<List<Tetkik>>(Messages.TetkikNotFound);
            }
            return new SuccessDataResult<List<Tetkik>>(result, Messages.TetkikListed);
        }

        public IDataResult<Tetkik> GetById(int id)
        {
            var result = _tetkikDal.Get(t => t.tetkikID == id);
            if (result is null)
            {
                return new ErrorDataResult<Tetkik>(Messages.TetkikNotFound);
            }
            return new SuccessDataResult<Tetkik>(result, Messages.TetkikFound);
        }

        public IResult Update(Tetkik tetkik)
        {
            _tetkikDal.Update(tetkik);
            return new SuccessResult(Messages.TetkikUpdated);
        }
    }
}
