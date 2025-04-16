using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seequent.Core;
public class BoreholeApplicationService
{
    private readonly IUnitOfWork _unitOfWork;

    public BoreholeApplicationService(
        IUnitOfWork unitOfWork
    )
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<Borehole?> GetBoreholeAsync(long id)
    {
        return await _unitOfWork.Boreholes.GetByIdAsync(id);
    }

    public async Task<IEnumerable<long>> GetAllBoreholeIdsAsync()
    {
        return await _unitOfWork.Boreholes.GetAllIdsAsync();
    }

    public async Task<IEnumerable<long>> GetBoreholeIdsAsync(int xMin, int xMax, int yMin, int yMax)
    {
        return await _unitOfWork.Boreholes.GetBoreholeIdsAsync(xMin, xMax, yMin, yMax);
    }

    public async Task<Borehole> AddBorehole(Borehole borehole)
    {
        return await _unitOfWork.Boreholes.Add(borehole);
    }
}
