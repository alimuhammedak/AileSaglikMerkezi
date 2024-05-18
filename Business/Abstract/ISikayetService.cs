using Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Result;

namespace Business.Abstract
{
    public interface ISikayetService
    {
        IDataResult<List<Sikayet>> GetAll();
        IDataResult<Sikayet> GetById(int id);
        IResult Add(Sikayet Sikayet);
        IResult Update(Sikayet Sikayet);
        IResult Delete(Sikayet Sikayet);
    }
}
