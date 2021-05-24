using Application.Common;
using Application.Entities;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Application.Contract.Model.Products;

namespace Application.Repository.Products
{
    public class ProductRepostiory : RespositoryBase<Entities.Product, ShopDbContext>, IProductRepository
    {
        public ProductRepostiory(ShopDbContext context) : base(context)
        {

        }
        public async Task<List<ProductReponseModel>> DienThoaiMoiNhat()
        {
            var query = await DbSet.Where(x => x.Categories.ParentId.Equals(10))
                                  .OrderByDescending(x => x.DateCreated)
                                  .Select(m => new ProductReponseModel()
                                  {
                                      Caption = m.Caption,
                                      Id = m.Id,
                                      CategoryId = m.CategoryId,
                                      ImagePath = m.ImagePath,
                                      Name = m.Name,
                                      OldPrice = m.OldPrice,
                                      ParentId = m.Categories.ParentId,
                                      Price = m.Price,
                                      SeoTitle = m.SeoTitle,
                                      Stock = m.Stock
                                  }).Take(8).ToListAsync();
            return query;
        }

        public async Task<List<ProductReponseModel>> LapTopMoiNhat()
        {
            var query = await DbSet.Where(x => x.Categories.ParentId.Equals(2))
                                  .OrderByDescending(x => x.DateCreated)
                                  .Select(m => new ProductReponseModel()
                                  {
                                      Caption = m.Caption,
                                      Id = m.Id,
                                      CategoryId = m.CategoryId,
                                      ImagePath = m.ImagePath,
                                      Name = m.Name,
                                      OldPrice = m.OldPrice,
                                      ParentId = m.Categories.ParentId,
                                      Price = m.Price,
                                      SeoTitle = m.SeoTitle,
                                      Stock = m.Stock
                                  }).Take(8).ToListAsync();
            return query;
        }

        //public async Task<PagedList<Product>> ListProductByCategoryId(int id, OwnerParameters ownerParameters)
        //{
        //    var source = DbSet.Where(x => x.CategoryId == id).AsNoTracking();

        //    return await PagedList<Entities.Product>.ToPagedList(source, ownerParameters.PageNumber, ownerParameters.PageSize);
        //}

        public async Task<List<ProductReponseModel>> ListProductByCategoryId(int id)
        {
            var query = await DbSet.Where(x => x.Categories.Id.Equals(id))
                                   .Select(m => new ProductReponseModel()
                                   {
                                       Caption = m.Caption,
                                       Id = m.Id,
                                       CategoryId = m.CategoryId,
                                       ImagePath = m.ImagePath,
                                       Name = m.Name,
                                       OldPrice = m.OldPrice,
                                       ParentId = m.Categories.ParentId,
                                       Price = m.Price,
                                       SeoTitle = m.SeoTitle,
                                       Stock = m.Stock
                                   }).ToListAsync();
            return query;
        }

        public async Task<List<Entities.Product>> SeletedTop8ById(int id)
        {
            var query = await Context.Products.Where(x => x.Categories.ParentId == id).Take(8).OrderByDescending(x => x.DateCreated).ToListAsync();
            return  query;

           
        }
    }
}
