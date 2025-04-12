using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Seequent.API;
using Seequent.Core;

namespace SeequentApi.Controllers
{
    [ApiController]
    [Route("borehole")]
    public class BoreholeController : ControllerBase
    {
        private readonly ILogger<BoreholeController> _logger;
        private readonly BoreholeService _boreholeService;

        public BoreholeController(
            ILogger<BoreholeController> logger,
            BoreholeService boreholeService)
        {
            _logger = logger;
            _boreholeService = boreholeService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Borehole>>> GetAll()
        {
            var borehole = await _boreholeService.GetAllBoreholes();

            return Ok(borehole);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Borehole>> GetById(long id)
        {
            var borehole = await _boreholeService.GetBorehole(id);
            if (borehole == null)
            {
                return NotFound();
            }

            return Ok(borehole);
        }
    }
}
