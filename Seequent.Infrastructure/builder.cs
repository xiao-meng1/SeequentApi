using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Seequent.Infrastructure;

public static class builder
{
    public static IServiceCollection Builder(this IServiceCollection services, IConfiguration configuration)
    {
        var conn = configuration.GetConnectionString("SeequentDbConnection");

        services.AddDbContext<See>
    }
}
