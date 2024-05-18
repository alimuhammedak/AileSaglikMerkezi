using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Mapper
{

    public interface IAutoMapperConfiguration
    {
        IMapper Configure(Profile profile);
    }

}
