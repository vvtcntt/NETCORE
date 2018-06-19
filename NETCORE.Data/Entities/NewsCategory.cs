using NETCORE.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using NETCORE.Data.Enums;
using NETCORE.Infrastructure.SharedKernel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NETCORE.Data.Entites
{
    [Table("NewsCategories")]
    public class NewsCategory : DomainEntity<int>, ISwitchable,INameable,ISortable,IHasSeoMetaData
    {

        public Status Status { set; get; }
        public string Name { set; get; }
      
        public string Alias { set; get; }
        [StringLength(250)]

        public string Description { set; get; }
        public virtual ICollection<News> News { set; get; }
        public int SorOrder { set; get; }
        public string SeoTitle  { set; get; }
        public string SeoAlias  { set; get; }
        public string SeoKeyWords  { set; get; }
        public string SeoDescription  { set; get; }
    }
}
