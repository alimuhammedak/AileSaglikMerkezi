using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Constans;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Entity;

namespace Business.Concrete
{
    public class IlacManager : IIlacService
    {
        private IIlacDal _ilacDal;

        public IlacManager(IIlacDal ilacDal)
        {
            _ilacDal = ilacDal;
        }

        public IResult Add(Ilac ilac)
        {
            _ilacDal.Add(ilac);
            return new SuccessResult(Messages.IlacAdded);
        }

        public IResult Delete(Ilac ilac)
        {
            _ilacDal.Delete(ilac);
            return new SuccessResult(Messages.IlacDeleted);
        }

        public IDataResult<List<Ilac>> GetAll()
        {
            var data = _ilacDal.GetAll();
            return new SuccessDataResult<List<Ilac>>(data, Messages.IlacListed);
        }

        public IDataResult<Ilac> GetById(int id)
        {
            var data = _ilacDal.Get(i => i.ilacID == id);
            return new SuccessDataResult<Ilac>(data, Messages.IlacListed);
        }

        public IResult Update(Ilac ilac)
        {
            _ilacDal.Update(ilac);
            return new SuccessResult(Messages.IlacUpdated);
        }
    }
}
