using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using OnlinesShop.Core.Entities;
using OnlinesShop.Infrastructure.Dto;

namespace OnlinesShop.Application.Mapping
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Product, ProductDto>().ReverseMap();
        }
    }
}
