using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Seequent.API;
using Seequent.Core;

namespace SeequentApi.Controllers
{
    [ApiController]
    [Route("Borehole")]
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

        [HttpGet("GetAllIds")]
        public async Task<ActionResult<List<long>>> GetAllIdsAsync()
        {
            var borehole = await _boreholeService.GetAllBoreholeIdsAsync();

            return Ok(borehole);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Borehole>> GetByIdAsync(long id)
        {
            var borehole = await _boreholeService.GetBoreholeAsync(id);
            if (borehole == null)
            {
                return NotFound();
            }

            return Ok(borehole);
        }

        [HttpGet("GetIds")]
        public async Task<ActionResult<List<long>>> GetIdsAsync(int x1, int x2, int y1, int y2)
        {
            var boreholeIds = await _boreholeService.GetBoreholeIdsAsync(x1, x2, y1, y2);

            return Ok(boreholeIds);
        }

        [HttpPost]
        public async Task<ActionResult> AddBorehole(Borehole boreholeDto)
        {
            var borehole = await _boreholeService.AddBorehole(boreholeDto);

            return Ok(borehole);
        }
    }
}
