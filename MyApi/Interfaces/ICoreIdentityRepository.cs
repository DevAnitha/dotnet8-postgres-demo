using System.Collections.Generic;
using System.Threading.Tasks;
using Contact.Domain.Entities;

namespace MyApi.Interfaces
{
    public interface ICoreIdentityRepository : IGenericRepository<CoreIdentity>
    {
        // Add custom queries if needed later
        Task<IEnumerable<CoreIdentity>> GetByLastNameAsync(string lastName);
    }
}
