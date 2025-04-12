namespace Seequent.Core;

public interface IUnitOfWork
{
    public IBoreholeRepository Boreholes { get; }
}
