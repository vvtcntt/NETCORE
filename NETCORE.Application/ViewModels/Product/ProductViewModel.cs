﻿using NETCORE.Data.Entites;
using NETCORE.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace NETCORE.Application.ViewModels.Product
{
    public class ProductViewModel
    {
        
        public int Id { set; get; }
        public string Name { get; set; }

        public int CategoryId { set; get; }

        public ProductCategoryViewModel ProductCategory { set; get; }

        public string Code { get; set; }
        public string Description { get; set; }
        public string Info { get; set; }
        public string Content { get; set; }
        public string Parameter { get; set; }
        public string ImageDetail { get; set; }

        public string ImageThumbs { get; set; }

        public decimal Price { get; set; }

        public decimal PriceSale { get; set; }

        public string NotePrice { get; set; }

        public int Warranty { get; set; }

        public int Age { get; set; }

        public string Sale { get; set; }


        public string Size { get; set; }
        public bool Vat { get; set; }
        public bool New { get; set; }
        public bool ProductSale { get; set; }
        public bool HomeFlag { get; set; }
        public int Ord { set; get; }
        public DateTime DateCreated { set; get; }
        public DateTime DateModified { set; get; }
        public string TitleMeta { set; get; }
        public string KeywordMeta { set; get; }
        public string DescriptionMeta { set; get; }
        public string Alias { set; get; }
        public Status Status { set; get; }
        public int LanguageId { set; get; }
        public int ViewCount { set; get; }
        public Status Active { set; get; }
        public string Tag { set; get; }
        public ICollection<ProductTagViewModel> ProductTags { set; get; }
    }
}
