using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Seequent.Core;

namespace Seequent.Infrastructure;
public class UnitOfWork : IUnitOfWork
{
    public UnitOfWork(SeequentDbContext context)
    {
        Boreholes = new BoreholeRepository(context);
    }

    public IBoreholeRepository Boreholes { get; }
}
