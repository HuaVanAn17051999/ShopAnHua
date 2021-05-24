using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repository.ThongSoKiThuat
{
    public interface IThongSoKiThuatRepository : IRepositoryBase<Entities.ThongSoKiThuat>
    {
        Task<Entities.ThongSoKiThuat> GetByProductId(int id);
    }
}
