using NETCORE.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace NETCORE.Data.Interfaces
{
    public interface ISwitchable
    {
        Status Status { set; get; }
    }
}
