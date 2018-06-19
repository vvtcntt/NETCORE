using System;
using System.Collections.Generic;
using System.Text;

namespace NETCORE.Data.Interfaces
{
    public interface IHasOwner<T>
    {
        T OwnerId {set;get ;}

    }
}
