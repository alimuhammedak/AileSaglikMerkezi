using Core.DataAccess;
using Entities.DTOs;
using Entities.DTOs.DoktorHastaListeDtos;
using Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IDoktorDal : IEntityRepository<Doktor>
    {
        List<DoktorDto> GetAllDoktorListe(Expression<Func<DoktorDto, bool>> filter = null);
    }
}
