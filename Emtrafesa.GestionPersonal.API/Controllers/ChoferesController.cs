using Emtrafesa.GestionPersonal.Application.Dtos;
using Emtrafesa.GestionPersonal.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Emtrafesa.GestionPersonal.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChoferesController : ControllerBase
    {
        private readonly IChoferApplication choferApplication;

        public ChoferesController(IChoferApplication choferApplication)
        {
            this.choferApplication = choferApplication;
        }

        [HttpGet]
        public async Task<ActionResult<List<ChoferDto>>> ListarChoferes()
        {
            var choferes = await choferApplication.ListarChoferes();
            return choferes;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ChoferDetalleDto>> ObtenerChofer(int id)
        {
            var chofer = await choferApplication.ObtenerChofer(id);
            if (chofer == null)
            {
                return NotFound("$ No se encontro el ID {id}");
            }
            return chofer;
        }

        [HttpPost]
        public async Task<ActionResult> InsertarChofer(ChoferCreacionDto choferCreacionDto)
        {
            await choferApplication.InsertarChofer(choferCreacionDto);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> EliminarChofer([FromRoute]int id)
        {
            await choferApplication.EliminarChofer(id);
            return Ok();
        }
    }
}
