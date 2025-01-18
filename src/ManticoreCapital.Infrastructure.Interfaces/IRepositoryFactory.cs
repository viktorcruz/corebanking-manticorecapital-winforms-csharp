namespace ManticoreCapital.Infrastructure.Interfaces
{
    public interface IRepositoryFactory<TInterface> where TInterface : class
    {
        TInterface GetRepository(string type);
    }
}
