using Core.Utilities.Result;
using Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IHastaIlacRaporService
    {
        IDataResult<List<HastaIlacRapor>> GetAll();
        IDataResult<HastaIlacRapor> GetById(int id);
        IResult Add(HastaIlacRapor HastaIlacRapor);
        IResult Update(HastaIlacRapor HastaIlacRapor);
        IResult Delete(HastaIlacRapor HastaIlacRapor);
    }
}
