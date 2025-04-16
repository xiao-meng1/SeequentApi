using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seequent.Core;
public interface IBoreholeRepository : IRepository<Borehole>
{
    Task<IEnumerable<long>> GetAllIdsAsync();
    Task<IEnumerable<long>> GetBoreholeIdsAsync(int xMin, int xMax, int yMin, int yMax);
}
