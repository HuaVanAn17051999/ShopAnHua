using Application.Common;
using Application.Contract.Model.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repository.Products
{
    public interface IProductRepository : IRepositoryBase<Entities.Product>
    {
        //Task<PagedList<Entities.Product>> ListProductByCategoryId(int id, OwnerParameters ownerParameters);
        Task<List<ProductReponseModel>> ListProductByCategoryId(int id);
        Task<List<ProductReponseModel>> DienThoaiMoiNhat();
        Task<List<ProductReponseModel>> LapTopMoiNhat();
        Task<List<Entities.Product>> SeletedTop8ById(int id);

    }
}
