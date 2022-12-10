using BAL.DTOs;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BAL.Profiles
{
    public class ApplicationProfile : AutoMapper.Profile
    {
        protected ApplicationProfile()
        {
            CreateMap<Product, ProductDTO>()
                .ForMember(d => d.CategoryId, opt => opt.MapFrom(c => c.CategoryId))
                .ForMember(d => d.CategoryName, opt => opt.MapFrom(c => c.Category.Name));

            CreateMap<ProductDTO, Product>()
                .ForMember(d => d.CategoryId, opt => opt.MapFrom(c => c.CategoryId));
               
        }
    }
}
