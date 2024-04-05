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
    public class HastaManager : IHastaService
    {
        private IHastaDal _hastaDal;

        public HastaManager(IHastaDal hastaDal)
        {
            _hastaDal = hastaDal;
        }

        public IResult Add(Hasta hasta)
        {
            //Validation
            if (hasta.ad.Length < 2 )
            {
                return new ErrorResult("Hasta adı en az 2 karakter olmalıdır");
            }

            //Business codes

            //hasat kayıt sadece 08-17 saatleri arasında yapılabilir
            //if (DateTime.Now.Hour < 8 || DateTime.Now.Hour > 17)
            //{
            //    return new ErrorResult("Hasta kaydı sadece 08:00-17:00 saatleri arasında yapılabilir");
            //}

            _hastaDal.Add(hasta);
            return new SuccessResult(Messages.HastaAdded);
        }

        public IResult Delete(Hasta hasta)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Hasta>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<Hasta> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Hasta hasta)
        {
            throw new NotImplementedException();
        }
    }
}
