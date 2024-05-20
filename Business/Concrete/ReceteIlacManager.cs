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
    public class ReceteIlacManager : IReceteIlacService
    {
        private readonly IReceteIlacDal _receteIlacDal;

        public ReceteIlacManager(IReceteIlacDal receteIlacDal)
        {
            _receteIlacDal = receteIlacDal;
        }

        public IResult Add(ReceteIlac receteIlac)
        {
            _receteIlacDal.Add(receteIlac);
            return new SuccessResult(Messages.ReceteIlacAdded);
        }

        public IResult Delete(ReceteIlac receteIlac)
        {
            _receteIlacDal.Delete(receteIlac);
            return new SuccessResult(Messages.ReceteIlacDeleted);
        }

        public IDataResult<List<ReceteIlac>> GetAll()
        {
            var result = _receteIlacDal.GetAll();
            return new SuccessDataResult<List<ReceteIlac>>(result, Messages.ReceteIlacListed);
        }

        public IDataResult<ReceteIlac> GetById(int id)
        {
            var result = _receteIlacDal.Get(r => r.receteIlacID == id);
            if (result == null)
            {
                return new ErrorDataResult<ReceteIlac>(Messages.ReceteIlacNotFound);
            }
            return new SuccessDataResult<ReceteIlac>(result, Messages.ReceteIlacFound);
        }

        public IResult Update(ReceteIlac receteIlac)
        {
            _receteIlacDal.Update(receteIlac);
            return new SuccessResult(Messages.ReceteIlacUpdated);
        }
    }
}