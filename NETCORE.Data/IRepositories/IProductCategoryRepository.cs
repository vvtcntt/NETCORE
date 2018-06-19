using NETCORE.Data.Entites;
using NETCORE.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace NETCORE.Data.iRepositories
{
    public interface IProductCategoryRepository:IRepository<ProductCategory,int>
    {
        List<ProductCategory> GetByAlias(string alias);
    }
}
