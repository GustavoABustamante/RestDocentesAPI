using RestDocentesAPI.Data.DTO;
using RestDocentesAPI.Data.Entities;

namespace RestDocentesAPI.Services
{
    public interface IDocentesService
    {
        Task<List<Docente>> GetDocentes();
        Task<Docente> AddDocente(Docente request);
    }
}
