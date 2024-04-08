using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess;
using Entities.Entity;

namespace DataAccess.Abstract
{
    public interface IPersonelDal:IEntityRepository<Personel>
    {
    }
}
