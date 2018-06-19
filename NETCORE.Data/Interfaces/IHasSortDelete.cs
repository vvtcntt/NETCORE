using System;
using System.Collections.Generic;
using System.Text;

namespace NETCORE.Data.Interfaces
{
   public interface IHasSortDelete
    {
        bool IsDeleted { set; get; }
    }
}
