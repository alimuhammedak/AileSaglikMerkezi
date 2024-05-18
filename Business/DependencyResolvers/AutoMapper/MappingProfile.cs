using AutoMapper;
using Entities.DTOs;
using Entities.DTOs.DoktorHastaListeDtos;
using Entities.DTOs.HastaCagirmaDtos;
using Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<HastaCagirmaDto, HastaCagirmaHastaDto>();
            CreateMap<HastaCagirmaDto, Hasta>();
            CreateMap<HastaListeDto, Hasta>()
                .ForMember(dest => dest.Cinsiyet, act => act.Ignore())
                .ForMember(dest => dest.HastaDetay, act => act.Ignore())
                .ForMember(dest => dest.HastaHastalik, act => act.Ignore())
                .ForMember(dest => dest.HastaIlacRapor, act => act.Ignore())
                .ForMember(dest => dest.HastaKayit, act => act.Ignore());

            CreateMap<Hasta, HastaListeDto>();

            //CreateMap<CarDetailEditDTO, Car>();
            //CreateMap<CarDetailEditDTO, Car>();
            //CreateMap<CarDetailEditDTO, Car>();

        }
    }
}
