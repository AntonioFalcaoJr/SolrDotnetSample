using System.Threading;
using System.Threading.Tasks;

namespace SolrDotnetSample.Application.Seeders
{
    public interface ISolrSeeder
    {
        Task SeedAsync(CancellationToken cancellationToken);
    }
}