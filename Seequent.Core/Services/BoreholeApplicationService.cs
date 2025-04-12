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

    public async Task<Borehole?> GetBorehole(long id)
    {
        return await _unitOfWork.Boreholes.GetById(id);
    }

    public async Task<IEnumerable<Borehole>> GetAllBoreholes()
    {
        return await _unitOfWork.Boreholes.GetAll();
    }
}
