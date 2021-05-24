using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.ThongSoKiThuat
{
    public interface IThongSoKiThuatService : IAppService<Entities.ThongSoKiThuat>
    {
        Task<Entities.ThongSoKiThuat> GetByProductId(int id);
    }
}
