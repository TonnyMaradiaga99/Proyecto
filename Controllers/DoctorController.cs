using System.Net;
using Microsoft.AspNetCore.Mvc;
using Proyecto.Models;

namespace Proyecto.Models
{
    [ApiController]
    [Route("/api/[controller]")]
    public class DoctorController : ControllerBase
    {
        IDoctorService DoctorService;
        public DoctorController(IDoctorService _DoctorService)
        {
            DoctorService = _DoctorService;
        }

        [HttpPost]
        public async Task<IActionResult> post([FromBody] Doctor newDoctor)
        {
            await DoctorService.CreateAsync(newDoctor);
            return Ok();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(DoctorService.Get());
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, [FromBody] Doctor newDoctor)
        {
            await DoctorService.Update(id, newDoctor);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await DoctorService.Delete(id);
            return Ok();
        }

    }


}