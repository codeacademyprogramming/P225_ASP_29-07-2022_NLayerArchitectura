using AutoMapper;
using P225NLayerArchitectura.Core.Entities;
using P225NLayerArchitectura.Service.DTOs.CategoryDTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace P225NLayerArchitectura.Service.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CategoryPostDto, Category>()
                .ForMember(des => des.CreatedAt, src => src.MapFrom(s => DateTime.UtcNow.AddHours(4)));

            CreateMap<Category, CategoryListDto>();
        }
    }
}
