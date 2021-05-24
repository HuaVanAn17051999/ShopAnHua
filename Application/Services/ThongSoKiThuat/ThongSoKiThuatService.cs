using Application.Common;
using Application.Contract.Exceptions;
using Application.Logging;
using Application.Repository.ThongSoKiThuat;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.ThongSoKiThuat
{
    public class ThongSoKiThuatService : BaseAppService, IThongSoKiThuatService
    {
        private readonly string seviceName = nameof(ThongSoKiThuatService);
        private readonly IThongSoKiThuatRepository _thongSoKiThuatRepository;
        private readonly IStorageService _storageService;
        public ThongSoKiThuatService(IMapper mapper,
            IHttpContextAccessor httpContextAccessor,
            UserManager<Entities.User> userManager,
            IStorageService storageService,
            IThongSoKiThuatRepository thongSoKiThuatRepository
             )
            : base(mapper, userManager, httpContextAccessor)
        {
            _thongSoKiThuatRepository = thongSoKiThuatRepository;
            _storageService = storageService;
        }
        public async Task<Entities.ThongSoKiThuat> GetByProductId(int id)
        {
            const string actionName = nameof(GetByProductId);

            if (String.IsNullOrEmpty(id.ToString()))
            {
                throw new NotFoundException(nameof(id));
            }

            Logger.LogDebug(LoggingMessage.ProcessingInService, actionName, seviceName, id);

            var response = await _thongSoKiThuatRepository.GetByProductId(id);

            if (response == null)
            {
                throw new NotFoundException(nameof(id));
            }

            return response;
        }
    }
}
