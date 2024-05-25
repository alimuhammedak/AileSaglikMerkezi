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
                .ForMember(dest => dest.HastaDetays, act => act.Ignore())
                .ForMember(dest => dest.HastaHastaliks, act => act.Ignore())
                .ForMember(dest => dest.HastaIlacRapors, act => act.Ignore())
                .ForMember(dest => dest.HastaKayits, act => act.Ignore());

            CreateMap<Hasta, HastaListeDto>();
            CreateMap<Doktor, DoktorDto>();

            //CreateMap<CarDetailEditDTO, Car>();
            //CreateMap<CarDetailEditDTO, Car>();
            //CreateMap<CarDetailEditDTO, Car>();

        }
    }
}
