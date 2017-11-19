using EntitiesAzure.Domain;

namespace Repository.Services
{
    public class AzureRepository : GenericRepository<AzureResultsEntities, Rezultate>, IRepository<Rezultate>
    {
    }
}
