using Core.DataAccess.EntityFramework;
using Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfHastaDal:EfEntityRepositoryBase<Hasta,SODBContext>,IHastaDal
    {

    }
}
