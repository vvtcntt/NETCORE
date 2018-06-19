using System;
using System.Collections.Generic;
using System.Text;

namespace NETCORE.Data.Interfaces
{
  public  interface IHasSeoMetaData
    {
         string SeoTitle{ get; set; }
         string SeoAlias { get; set; }
         string SeoKeyWords { get; set; }
         string SeoDescription { get; set; }


    }
}
