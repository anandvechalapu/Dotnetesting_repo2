namespace Dotnetesting.Service
{
    using System.Threading.Tasks;
    using Dotnetesting.DataAccess;
    using Dotnetesting.DTO;
    using Dotnetesting.Models;

    public interface ISezCustomerLogicCheckAtClientSchemeCreationService
    {
        Task<SezCustomerLogicCheckAtClientSchemeCreationDTO> GetByIdAsync(int id);
        Task<SezCustomerLogicCheckAtClientSchemeCreationDTO> CreateAsync(SezCustomerLogicCheckAtClientSchemeCreationDTO dto);
        Task<SezCustomerLogicCheckAtClientSchemeCreationDTO> UpdateAsync(SezCustomerLogicCheckAtClientSchemeCreationDTO dto);
        Task DeleteAsync(SezCustomerLogicCheckAtClientSchemeCreationDTO dto);
    }
}