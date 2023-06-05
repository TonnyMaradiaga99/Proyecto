using System.Net;
using Microsoft.AspNetCore.Mvc;
using Proyecto.Models;

namespace Proyecto.Models
{
    [ApiController]
    [Route("/api/[controller]")]
    public class CitaController : ControllerBase
    {
        ICitaService CitaService;
        public CitaController(ICitaService _CitaService)
        {
            CitaService = _CitaService;
        }

        [HttpPost]
        public async Task<IActionResult> post([FromBody] Cita newCita)
        {
            await CitaService.CreateAsync(newCita);
            return Ok();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(CitaService.Get());
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, [FromBody] Cita newCita)
        {
            await CitaService.Update(id, newCita);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await CitaService.Delete(id);
            return Ok();
        }

    }


}