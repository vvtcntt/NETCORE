﻿using NETCORE.Data.Entites;
using NETCORE.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace NETCORE.Application.ViewModels.Product
{
    public class ProductCategoryViewModel
    {
        public int Id { set; get; }
        public string Name { get; set; }
        public int? ParentId { get; set; }
    
        public string Description { get; set; }
        public string Content { get; set; }
      
        public string Image { get; set; }
     
        public string Icon { get; set; }
        public bool? HomeFlag { get; set; }
        public int Ord { set; get; }
        public DateTime DateCreated { set; get; }
        public DateTime DateModified { set; get; }
        public string TitleMeta { set; get; }
        public string KeywordMeta { set; get; }
        public string DescriptionMeta { set; get; }
        public string Alias { set; get; }
        public int LanguageId { set; get; }
        public Status Status { set; get; }
        public  ICollection<ProductViewModel> Products { set; get; }
    }
}
