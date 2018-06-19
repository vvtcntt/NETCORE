using NETCORE.Data.Interfaces;
using NETCORE.Infrastructure.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;
using NETCORE.Data.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace NETCORE.Data.Entites
{
    public class ImageCategory : DomainEntity<int>, INameable, ISortable, ISwitchable
    {
        public int Ord { set; get; }
        public Status Status { set; get; }
        string INameable.Name { set; get; }

        public virtual ICollection<Image> Images { set; get; }
        public int SorOrder { set; get; }
    }
}