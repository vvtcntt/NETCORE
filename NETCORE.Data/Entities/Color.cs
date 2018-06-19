using NETCORE.Data.Interfaces;
using NETCORE.Infrastructure.SharedKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace NETCORE.Data.Entites
{
    [Table("Colors")]
    public class Color : DomainEntity<int>,INameable
    {


        public string Name { get; set; }

        [StringLength(250)]
        public string Code { get; set; }
    }
}
