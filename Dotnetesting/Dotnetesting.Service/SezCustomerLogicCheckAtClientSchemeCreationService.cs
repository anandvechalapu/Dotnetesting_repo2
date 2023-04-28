namespace Dotnetesting.Service
{
    using System.Threading.Tasks;
    using Dotnetesting.DataAccess;
    using Dotnetesting.DTO;
    using Dotnetesting.Models;

    public class SezCustomerLogicCheckAtClientSchemeCreationService : ISezCustomerLogicCheckAtClientSchemeCreationService 
    {
        private readonly SezCustomerLogicCheckAtClientSchemeCreationRepository _repository;

        public SezCustomerLogicCheckAtClientSchemeCreationService(SezCustomerLogicCheckAtClientSchemeCreationRepository repository)
        {
            _repository = repository;
        }

        public async Task<SezCustomerLogicCheckAtClientSchemeCreationDTO> GetByIdAsync(int id)
        {
            var model = await _repository.GetByIdAsync(id);
            return new SezCustomerLogicCheckAtClientSchemeCreationDTO
            {
                Id = model.Id,
                // other properties
            };
        }

        public async Task<SezCustomerLogicCheckAtClientSchemeCreationDTO> CreateAsync(SezCustomerLogicCheckAtClientSchemeCreationDTO dto)
        {
            var model = new SezCustomerLogicCheckAtClientSchemeCreationModel
            {
                // other properties
            };
            model = await _repository.CreateAsync(model);
            return new SezCustomerLogicCheckAtClientSchemeCreationDTO
            {
                Id = model.Id,
                // other properties
            };
        }

        public async Task<SezCustomerLogicCheckAtClientSchemeCreationDTO> UpdateAsync(SezCustomerLogicCheckAtClientSchemeCreationDTO dto)
        {
            var model = new SezCustomerLogicCheckAtClientSchemeCreationModel
            {
                Id = dto.Id,
                // other properties
            };
            model = await _repository.UpdateAsync(model);
            return new SezCustomerLogicCheckAtClientSchemeCreationDTO
            {
                Id = model.Id,
                // other properties
            };
        }

        public async Task DeleteAsync(SezCustomerLogicCheckAtClientSchemeCreationDTO dto)
        {
            var model = new SezCustomerLogicCheckAtClientSchemeCreationModel
            {
                Id = dto.Id,
                // other properties
            };
            await _repository.DeleteAsync(model);
        }
    }
}