using Application.Entities;
using Application.Logging;
using Application.Services.ThongSoKiThuat;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("/api/v1/ThongSoKiThuat")]
    public class ThongSoKiThuatController : BaseController
    {
        private readonly IThongSoKiThuatService _thongSoKiThuatService;
        public ThongSoKiThuatController(UserManager<User> userManager,
            IThongSoKiThuatService thongSoKiThuatService)
            : base(userManager)
        {
            _thongSoKiThuatService = thongSoKiThuatService;
        }
        /// <summary>
        /// GetByProductId product async
        /// </summary>
        /// <param name="id">product id to GetByProductId</param>
        /// <response code="204">GetByProductId  successfuly</response> 
        /// <response code="500">Internal error server</response>
        [HttpGet("GetByProductId/{id}")]
        [AllowAnonymous]
        public async Task<ActionResult> GetByProductId(int id)
        {
            const string actionName = nameof(GetByProductId);

            Logger.LogDebug(LoggingMessage.ProcessingRequestWithModel, actionName, id);

            var response = await _thongSoKiThuatService.GetByProductId(id);

            Logger.LogDebug(LoggingMessage.RequestResults, actionName);

            return Ok(response);
        }
    }
}
