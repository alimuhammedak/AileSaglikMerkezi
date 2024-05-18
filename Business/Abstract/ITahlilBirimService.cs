using Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Result;

namespace Business.Abstract
{
    public interface ITahlilBirimService
    {
        IDataResult<List<TahlilBirim>> GetAll();
        IDataResult<TahlilBirim> GetById(int id);
        IResult Add(TahlilBirim TahlilBirim);
        IResult Update(TahlilBirim TahlilBirim);
        IResult Delete(TahlilBirim TahlilBirim);
    }
}
