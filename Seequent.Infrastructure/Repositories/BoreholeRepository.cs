using Microsoft.EntityFrameworkCore;
using Seequent.Core;

namespace Seequent.Infrastructure;
public class BoreholeRepository : Repository<Borehole>, IBoreholeRepository
{
    private readonly SeequentDbContext _context;

    public BoreholeRepository(SeequentDbContext context) : base(context)
    {
        _context = context;
    }

    public async Task<IEnumerable<long>> GetAllIdsAsync()
    {
        return await _context.Boreholes
            .Select(x => x.Id)
            .ToListAsync();
    }

    public async Task<IEnumerable<Borehole>> GetBoreholeIdsAsync(int xMin, int xMax, int yMin, int yMax)
    {
        return await _context.Boreholes
            .Where(b => b.XLocationKm >= xMin &&
                        b.XLocationKm <= xMax &&
                        b.YLocationKm >= yMin &&
                        b.YLocationKm <= yMax)
            .ToListAsync();
    }
}
