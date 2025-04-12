using Seequent.Core;

namespace Seequent.Infrastructure;
public class BoreholeRepository : Repository<Borehole>, IBoreholeRepository
{
    private readonly SeequentDbContext _context;

    public BoreholeRepository(SeequentDbContext context) : base(context)
    {
        _context = context;
    }
}
