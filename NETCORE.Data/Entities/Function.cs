﻿using NETCORE.Data.Interfaces;
using NETCORE.Infrastructure.SharedKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using NETCORE.Data.Enums;

namespace NETCORE.Data.Entites
{
    [Table("Functions")]
    public class Function : DomainEntity<string>, ISwitchable, ISortable,INameable
    {
        public Function()
        {

        }
        public Function(string name, string url, string parentId, string iconCss, int sorOrder)
        {
            this.Name = name;
            this.URL = url;
            this.ParentId = parentId;
            this.IconCss = iconCss;
            this.SorOrder = sorOrder;
            this.Status = Status.Active;
        }
     
        public string Name { set; get; }

        [Required]
        [StringLength(250)]
        public string URL { set; get; }


        [StringLength(128)]
        public string ParentId { set; get; }

        public string IconCss { get; set; }
        public Status Status { set; get; }
        public int SorOrder { get; set; }
    }
}
