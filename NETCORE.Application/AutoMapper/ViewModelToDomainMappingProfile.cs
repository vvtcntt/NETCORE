﻿using AutoMapper;
using NETCORE.Application.ViewModels.Product;
using NETCORE.Data.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace NETCORE.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile:Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<ProductCategoryViewModel, ProductCategory>().
                ConstructUsing(x => new ProductCategory(x.Name, x.ParentId, x.Description, x.Content, x.Image, x.Icon, x.HomeFlag, x.Ord, x.DateCreated, x.DateModified, x.Alias, x.TitleMeta, x.KeywordMeta, x.DescriptionMeta, x.LanguageId, x.Status));
            CreateMap<ProductViewModel, Product>().
                ConstructUsing(x => new Product(x.Name, x.CategoryId, x.Code, x.Description, x.Info, x.Content, x.Parameter, x.ImageDetail, x.ImageThumbs, x.Price, x.PriceSale, x.NotePrice, x.Warranty, x.Age, x.Sale, x.Size, x.Vat, x.New, x.ProductSale, x.HomeFlag, x.Ord, x.DateCreated, x.DateModified, x.TitleMeta, x.KeywordMeta, x.DescriptionMeta, x.Alias, x.Status, x.LanguageId, x.ViewCount,x.Active, x.Tag));
            
        }
    }
}
