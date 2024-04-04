using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess;
using Entities.Entity;

namespace DataAccess.Abstract
{
    public interface IHastaDal:IEntityRepository<Hasta>
    {
    }
}
