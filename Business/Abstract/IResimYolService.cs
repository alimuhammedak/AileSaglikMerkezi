using Core.Utilities.Result;
using Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IResimYolService
    {
        IResult Add(ResimYolu resimYolu);
        IResult Update(ResimYolu resimYolu);
        IResult Delete(ResimYolu resimYolu);
        IDataResult<List<ResimYolu>> GetAll();
        IDataResult<ResimYolu> GetById(int id);
        IDataResult<ResimYolu> GetByHastaID(int id);
        IDataResult<ResimYolu> GetByKullaniciID(int id);
    }
}
