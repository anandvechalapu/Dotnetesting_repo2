using Dotnetesting.DTO;
using Dotnetesting.Repository;

namespace Dotnetesting.Service
{
    public interface ISezCustomerLogicCheckAtClientSchemeCreationRepository
    {
        Task<SezCustomerLogicCheckAtClientSchemeCreationModel> GetByIdAsync(int id);
        Task<SezCustomerLogicCheckAtClientSchemeCreationModel> CreateAsync(SezCustomerLogicCheckAtClientSchemeCreationModel model);
        Task<SezCustomerLogicCheckAtClientSchemeCreationModel> UpdateAsync(SezCustomerLogicCheckAtClientSchemeCreationModel model);
        Task DeleteAsync(SezCustomerLogicCheckAtClientSchemeCreationModel model);
    }
}