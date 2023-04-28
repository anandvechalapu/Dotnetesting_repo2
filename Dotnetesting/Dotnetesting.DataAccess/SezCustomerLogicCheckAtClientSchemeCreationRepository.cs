using System.Threading.Tasks;
using Dotnetesting.DTO;

namespace Dotnetesting
{
    public class SezCustomerLogicCheckAtClientSchemeCreationRepository : ISezCustomerLogicCheckAtClientSchemeCreationRepository 
    {
        private readonly SezCustomerLogicCheckAtClientSchemeCreationModel _model;

        public SezCustomerLogicCheckAtClientSchemeCreationRepository(SezCustomerLogicCheckAtClientSchemeCreationModel model)
        {
            _model = model;
        }

        public async Task<SezCustomerLogicCheckAtClientSchemeCreationDTO> GetSezCustomerLogicCheckAtClientSchemeCreationByIdAsync(int id)
        {
            var dto = new SezCustomerLogicCheckAtClientSchemeCreationDTO();
            if (_model.Id == id)
            {
                dto.Id = _model.Id;
                dto.ClientName = _model.ClientName;
                dto.SchemeName = _model.SchemeName;
                dto.Description = _model.Description;
                dto.IsActive = _model.IsActive;
            }
            return await Task.FromResult(dto);
        }

        public async Task<int> CreateSezCustomerLogicCheckAtClientSchemeCreationAsync()
        {
            // Code to save the model to the database
            return await Task.FromResult(_model.Id);
        }

        public async Task<bool> UpdateSezCustomerLogicCheckAtClientSchemeCreationAsync()
        {
            // Code to update the model in the database
            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteSezCustomerLogicCheckAtClientSchemeCreationAsync(int id)
        {
            // Code to delete the model from the database
            return await Task.FromResult(true);
        }
    }
}