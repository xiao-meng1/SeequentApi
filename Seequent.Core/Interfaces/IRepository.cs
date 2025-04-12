using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seequent.Core;
public interface IRepository<TEntity> where TEntity : class
{
    Task<TEntity?> GetById(long id);

    Task<IEnumerable<TEntity>> GetAll();
}
