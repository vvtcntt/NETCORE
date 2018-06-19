using NETCORE.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using NETCORE.Data.Enums;
using NETCORE.Infrastructure.SharedKernel;
using System.ComponentModel.DataAnnotations.Schema;

namespace NETCORE.Data.Entites
{
    [Table("Languages")]
    public class Language : DomainEntity<string>, ISwitchable,INameable
    {
       
        public string Name { get; set; }

        public bool IsDefault { get; set; }

        public string Resources { get; set; }
        public Status Status { get; set; }
    }
}
