namespace Dotnetesting.Repository
{
    using System.Threading.Tasks;
    using Dotnetesting.DTO;
    using Dotnetesting.Models;

    public class SezCustomerLogicCheckAtClientSchemeCreationRepository : ISezCustomerLogicCheckAtClientSchemeCreationRepository
    {
        private readonly SezCustomerLogicCheckAtClientSchemeCreationContext _context;

        public SezCustomerLogicCheckAtClientSchemeCreationRepository(SezCustomerLogicCheckAtClientSchemeCreationContext context)
        {
            _context = context;
        }

        public async Task<SezCustomerLogicCheckAtClientSchemeCreationModel> GetByIdAsync(int id)
        {
            return await _context.SezCustomerLogicCheckAtClientSchemeCreation.FindAsync(id);
        }

        public async Task<SezCustomerLogicCheckAtClientSchemeCreationModel> CreateAsync(SezCustomerLogicCheckAtClientSchemeCreationModel model)
        {
            _context.SezCustomerLogicCheckAtClientSchemeCreation.Add(model);
            await _context.SaveChangesAsync();
            return model;
        }

        public async Task<SezCustomerLogicCheckAtClientSchemeCreationModel> UpdateAsync(SezCustomerLogicCheckAtClientSchemeCreationModel model)
        {
            _context.SezCustomerLogicCheckAtClientSchemeCreation.Update(model);
            await _context.SaveChangesAsync();
            return model;
        }

        public async Task DeleteAsync(SezCustomerLogicCheckAtClientSchemeCreationModel model)
        {
            _context.SezCustomerLogicCheckAtClientSchemeCreation.Remove(model);
            await _context.SaveChangesAsync();
        }
    }
}