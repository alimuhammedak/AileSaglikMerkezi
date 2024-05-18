using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfTedarikciDal : EfEntityRepositoryBase<Tedarikci, SODBContext>, ITedarikciDal
    {
    }
}
