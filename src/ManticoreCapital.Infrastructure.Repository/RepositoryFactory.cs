using Microsoft.Extensions.DependencyInjection;

namespace ManticoreCapital.Infrastructure.Repositories
{
    public class RepositoryFactory<TRepository> where TRepository : class
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly Dictionary<RepositoryType, Type> _repositoryTypes = new();

        public RepositoryFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void RegisterRepository(RepositoryType key, Type repositoryType)
        {
            if (!typeof(TRepository).IsAssignableFrom(repositoryType))
                throw new ArgumentException($"El tipo {repositoryType.Name} no implementa {typeof(TRepository).Name}");

            if (_repositoryTypes.ContainsKey(key))
                throw new ArgumentException($"La clave '{key}' ya ha sido registrada.");

            _repositoryTypes[key] = repositoryType;
        }

        public TRepository GetRepository(RepositoryType key)
        {
            if (!_repositoryTypes.TryGetValue(key, out var repositoryType))
                throw new KeyNotFoundException($"No se encontró un repositorio para la clave '{key}'.");

            return (TRepository)_serviceProvider.GetRequiredService(repositoryType);
        }
    }
}
