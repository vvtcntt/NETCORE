using NETCORE.Application.ViewModels.Product;
//using NETCORE.Utilities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace NETCORE.Application.Interfaces
{
    public interface  IProductService:IDisposable
    {
        List<ProductViewModel> GetAll();
        ProductViewModel GetById(int id);
        //PagedResult<ProductViewModel> GetAllPaging(int? categogyId,string keyword, int page, int pageSize);
        ProductViewModel Add(ProductViewModel productVm);
        void delete(int id);
        void Save();
        void ImportExcel(string filePath, int categoryId);
        void Update(ProductViewModel productVm);
    }
}
