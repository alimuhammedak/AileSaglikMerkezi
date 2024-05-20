using Core.Utilities.Result;
using Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IKullaniciService
    {
        IResult Add(Kullanici entity);
        IResult Update(Kullanici entity);
        IResult Delete(Kullanici entity);
        IDataResult<Kullanici> GetById(int id);
        IDataResult<Kullanici> GetByIdentityNumber(string identityNumber);
        IDataResult<List<Kullanici>> GetAll();
        IDataResult<Kullanici> GetByUserNameAndPassword(string userName, string password);
        IResult GetByUserPasswordReset(string identityNumber, string firstName, string lastName ,DateTime birthDate);
    }
}
