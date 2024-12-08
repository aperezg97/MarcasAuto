using MarcasAuto.Application.Interfaces;
using MarcasAuto.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MarcasAuto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarcasAutoController : ControllerBase
    {
        private readonly IMarcasAutoService _marcasAutoService;

        public MarcasAutoController(IMarcasAutoService marcasAutoService)
        {
            _marcasAutoService = marcasAutoService;
        }

        [HttpGet(Name = "")]
        public async Task<IEnumerable<MarcasAutoEntity>> GetAll()
        {
            return await _marcasAutoService.GetAll();
        }
    }
}
