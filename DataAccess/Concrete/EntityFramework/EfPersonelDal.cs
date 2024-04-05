using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Entity;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfPersonelDal:EfEntityRepositoryBase<Personel,SODBContext>,IPersonelDal
    {
    }
}
