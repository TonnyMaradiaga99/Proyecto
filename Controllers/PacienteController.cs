using System.Net;
using Microsoft.AspNetCore.Mvc;
using Proyecto.Models;

namespace Proyecto.Models
{
    [ApiController]
    [Route("/api/[controller]")]
    public class PacienteController : ControllerBase
    {
        IPacienteService PacienteService;
        public PacienteController(IPacienteService _PacienteService)
        {
            PacienteService = _PacienteService;
        }

        [HttpPost]
        public async Task<IActionResult> post([FromBody] Paciente newPaciente)
        {
            await PacienteService.CreateAsync(newPaciente);
            return Ok();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(PacienteService.Get());
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, [FromBody] Paciente newPaciente)
        {
            await PacienteService.Update(id, newPaciente);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await PacienteService.Delete(id);
            return Ok();
        }

    }


}