﻿using NETCORE.Data.Interfaces;
using NETCORE.Infrastructure.SharedKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace NETCORE.Data.Entites
{
    [Table("Sizes")]
    public class Size : DomainEntity<int>,INameable
    {

         public string Name
        {
            get; set;
        }
    }
}
