namespace Dotnetesting.Service
{
    using Dotnetesting.DTO;
    using System.Threading.Tasks;

    public interface ISezCustomerLogicCheckAtClientSchemeCreationRepository
    {
        Task<SezCustomerLogicCheckAtClientSchemeCreationDTO> GetSezCustomerLogicCheckAtClientSchemeCreationByIdAsync(int id);
        Task<int> CreateSezCustomerLogicCheckAtClientSchemeCreationAsync();
        Task<bool> UpdateSezCustomerLogicCheckAtClientSchemeCreationAsync();
        Task<bool> DeleteSezCustomerLogicCheckAtClientSchemeCreationAsync(int id);
    }
}