using System.Threading.Tasks;
using Dotnetesting.DataAccess;
using Dotnetesting.DTO;

namespace Dotnetesting.Service
{
    public interface ISezCustomerLogicCheckAtClientSchemeCreationService
    {
        Task<SezCustomerLogicCheckAtClientSchemeCreationDTO> GetSezCustomerLogicCheckAtClientSchemeCreationByIdAsync(int id);
        Task<int> CreateSezCustomerLogicCheckAtClientSchemeCreationAsync(SezCustomerLogicCheckAtClientSchemeCreationDTO model);
        Task<bool> UpdateSezCustomerLogicCheckAtClientSchemeCreationAsync(SezCustomerLogicCheckAtClientSchemeCreationDTO model);
        Task<bool> DeleteSezCustomerLogicCheckAtClientSchemeCreationAsync(int id);
    }
}