using RestDocentesAPI.Data.Entities;

namespace RestDocentesAPI.Data.Repositories
{
    public interface IDocentesRepository
    {
        Task<List<Docente>> GetAsync();
        public Task<Docente> AddAsync(Docente docente);
    }
}
