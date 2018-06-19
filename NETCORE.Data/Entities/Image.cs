using NETCORE.Data.Interfaces;
using NETCORE.Infrastructure.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;
using NETCORE.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NETCORE.Data.Entites
{ [Table("News")]
    public class Image : DomainEntity<int>, INameable,ISortable, ISwitchable
    {
        public string Name { set; get; }
        public int CategoryId { set; get; }
        [StringLength(200)]
        public string ImageLink { set; get; }
        public bool? TypeLink { set; get; }
        [StringLength(200)]
        public string Url { set; get; }
        public Status Status { set; get; }
        [ForeignKey("CategoryId")]
        public virtual ImageCategory ImageCategories { set; get; }
        public int SorOrder { set; get; }
    }
}
