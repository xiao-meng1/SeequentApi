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

    public async Task<Borehole?> GetBorehole(long id)
    {
        return await _boreholeApplicationService.GetBorehole(id);
    }

    public async Task<IEnumerable<Borehole>> GetAllBoreholes()
    {
        return await _boreholeApplicationService.GetAllBoreholes();
    }
}
