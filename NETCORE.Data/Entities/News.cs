using NETCORE.Data.Interfaces;
using NETCORE.Infrastructure.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;
using NETCORE.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NETCORE.Data.Entites
{
    [Table("News")]
    public class News : DomainEntity<int>, INameable, ISwitchable, IDateTracking, IHasSeoMetaData, ISortable
    {
       
        public DateTime DateCreated { set; get; }
        public DateTime DateModified { set; get; }
        public Status Status { set; get; }
        public string Name { set; get; }
        public int? CategoryId { set; get; }
        [StringLength(200)]

        public string Description { set; get; }
        public string Content { set; get; }
        public int? ViewCount { set; get; }
        public bool? ViewHomes { set; get; }
        [StringLength(200)]

        public string Image { set; get; }
        [ForeignKey("CategoryId")]
        public virtual NewsCategory NewsCategories { set; get; }
        public string SeoTitle  { set; get; }
        public string SeoAlias  { set; get; }
        public string SeoKeyWords  { set; get; }
        public string SeoDescription  { set; get; }
        public int SorOrder  { set; get; }
    }
}
