using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repository.ThongSoKiThuat
{
    public class ThongSoKiThuatRepository : RespositoryBase<Entities.ThongSoKiThuat, ShopDbContext>, IThongSoKiThuatRepository
    {
        public ThongSoKiThuatRepository(ShopDbContext context) : base(context)
        {

        }
        public async Task<Entities.ThongSoKiThuat> GetByProductId(int id)
        {
            var query = await DbSet.Where(x => x.ProductId == id).SingleOrDefaultAsync();
            return query;
        }
    }
}
