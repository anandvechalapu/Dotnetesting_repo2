using System.Threading.Tasks;
using Dotnetesting.DTO;
using Dotnetesting.Service;
using Microsoft.AspNetCore.Mvc;

namespace Dotnetesting.API
{
    [ApiController]
    public class SezCustomerLogicCheckAtClientSchemeCreationController : ControllerBase
    {
        private readonly SezCustomerLogicCheckAtClientSchemeCreationService _service;

        public SezCustomerLogicCheckAtClientSchemeCreationController(SezCustomerLogicCheckAtClientSchemeCreationService service)
        {
            _service = service;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<SezCustomerLogicCheckAtClientSchemeCreationDTO>> GetByIdAsync(int id)
        {
            var result = await _service.GetByIdAsync(id);
            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<SezCustomerLogicCheckAtClientSchemeCreationDTO>> CreateAsync(SezCustomerLogicCheckAtClientSchemeCreationDTO dto)
        {
            var result = await _service.CreateAsync(dto);

            return CreatedAtAction(nameof(GetByIdAsync), new { id = result.Id }, result);
        }

        [HttpPut]
        public async Task<ActionResult<SezCustomerLogicCheckAtClientSchemeCreationDTO>> UpdateAsync(SezCustomerLogicCheckAtClientSchemeCreationDTO dto)
        {
            var result = await _service.UpdateAsync(dto);
            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            var dto = new SezCustomerLogicCheckAtClientSchemeCreationDTO { Id = id };
            await _service.DeleteAsync(dto);

            return NoContent();
        }
    }
}