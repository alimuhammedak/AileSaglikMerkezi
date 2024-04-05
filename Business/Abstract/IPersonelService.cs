using Core.Utilities.Result;
using Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IPersonelService
    {
        IDataResult<List<Personel>> GetAll();
        IDataResult<Personel> GetById(int id);
        IDataResult<Personel> GetByUserNameAndPassword(string userName, string password);
        IResult Add(Personel personel);
        IResult Update(Personel personel);
        IResult Delete(Personel personel);
    }
}
