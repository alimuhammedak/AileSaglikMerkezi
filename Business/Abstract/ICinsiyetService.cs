using Core.Utilities.Result;
using Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICinsiyetService
    {
        IDataResult<List<Cinsiyet>> GetAll();
        IDataResult<Cinsiyet> GetById(int id);
        IResult Add(Cinsiyet Cinsiyet);
        IResult Update(Cinsiyet Cinsiyet);
        IResult Delete(Cinsiyet Cinsiyet);
    }
}
