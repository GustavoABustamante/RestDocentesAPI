using Microsoft.AspNetCore.Mvc;
using RestDocentesAPI.Data.Entities;
using RestDocentesAPI.Services;

namespace RestDocentesAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DocentesController : Controller
    {
        private readonly IDocentesService _docentesService;

        public DocentesController(IDocentesService docentesService)
        {
            _docentesService = docentesService;
        }

        [HttpGet(nameof(GetDocentes))]
        public async Task<IEnumerable<Docente>> GetDocentes() 
        {
            return await _docentesService.GetDocentes();
        }

        [HttpPost(nameof(AddDocente))]
        public async Task<Docente> AddDocente(Docente docente)
        {
            return await _docentesService.AddDocente(docente);
        }
    }
}
