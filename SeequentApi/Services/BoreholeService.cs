using Seequent.Core;
using Seequent.Infrastructure;

namespace Seequent.API;

public class BoreholeService
{
    private readonly BoreholeApplicationService _boreholeApplicationService;

    public BoreholeService(
        BoreholeApplicationService applicationService
    )
    {
        _boreholeApplicationService = applicationService;
    }

    public async Task<Borehole?> GetBoreholeAsync(long id)
    {
        return await _boreholeApplicationService.GetBoreholeAsync(id);
    }

    public async Task<IEnumerable<long>> GetAllBoreholeIdsAsync()
    {
        return await _boreholeApplicationService.GetAllBoreholeIdsAsync();
    }

    public async Task<IEnumerable<Borehole>> GetBoreholeIdsAsync(int x1, int x2, int y1, int y2)
    {
        var xMin = Math.Min(x1, x2);
        var xMax = Math.Max(x1, x2);
        var yMin = Math.Min(y1, y2);
        var yMax = Math.Max(y1, y2);

        return await _boreholeApplicationService.GetBoreholeIdsAsync(xMin, xMax, yMin, yMax);
    }

    public async Task<Borehole> AddBorehole(Borehole borehole)
    {
        return await _boreholeApplicationService.AddBorehole(borehole);
    }
}
