using AutoMapper;
using NETCORE.Application.ViewModels.Product;
using NETCORE.Data.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace NETCORE.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile:Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Product, ProductViewModel>();
            CreateMap<ProductCategory, ProductCategoryViewModel>();
           

        }
    }
}
