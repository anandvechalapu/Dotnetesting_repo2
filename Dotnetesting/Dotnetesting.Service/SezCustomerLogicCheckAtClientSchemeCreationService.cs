using System.Threading.Tasks;
using Dotnetesting.DataAccess;
using Dotnetesting.DTO;

namespace Dotnetesting.Service
{
    public class SezCustomerLogicCheckAtClientSchemeCreationService : ISezCustomerLogicCheckAtClientSchemeCreationService
    {
        private readonly ISezCustomerLogicCheckAtClientSchemeCreationRepository _repository;

        public SezCustomerLogicCheckAtClientSchemeCreationService(
            ISezCustomerLogicCheckAtClientSchemeCreationRepository repository)
        {
            _repository = repository;
        }

        public async Task<SezCustomerLogicCheckAtClientSchemeCreationDTO> GetSezCustomerLogicCheckAtClientSchemeCreationByIdAsync(int id)
        {
            return await _repository.GetSezCustomerLogicCheckAtClientSchemeCreationByIdAsync(id);
        }

        public async Task<int> CreateSezCustomerLogicCheckAtClientSchemeCreationAsync(SezCustomerLogicCheckAtClientSchemeCreationDTO model)
        {
            var repositoryModel = new SezCustomerLogicCheckAtClientSchemeCreationModel(model);
            return await _repository.CreateSezCustomerLogicCheckAtClientSchemeCreationAsync(repositoryModel);
        }

        public async Task<bool> UpdateSezCustomerLogicCheckAtClientSchemeCreationAsync(SezCustomerLogicCheckAtClientSchemeCreationDTO model)
        {
            var repositoryModel = new SezCustomerLogicCheckAtClientSchemeCreationModel(model);
            return await _repository.UpdateSezCustomerLogicCheckAtClientSchemeCreationAsync(repositoryModel);
        }

        public async Task<bool> DeleteSezCustomerLogicCheckAtClientSchemeCreationAsync(int id)
        {
            return await _repository.DeleteSezCustomerLogicCheckAtClientSchemeCreationAsync(id);
        }
    }
}