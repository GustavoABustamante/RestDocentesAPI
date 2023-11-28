using Microsoft.EntityFrameworkCore;
using RestDocentesAPI.Data.Entities;
using System.Data;

namespace RestDocentesAPI.Data.Repositories
{
    public class DocentesRepository : IDocentesRepository
    {
        private readonly DocentesContext _context;

        public DocentesRepository(DocentesContext context)
        {
            _context = context;
        }
        public async Task<Docente> AddAsync(Docente docente)
        {
            docente.Id = Guid.NewGuid().ToString();

            var existeDocente = (await GetAsync()).Where(d => d.Id == docente.Id).FirstOrDefault();

            if (existeDocente is not null)
            {
                throw new DataException($"Añadir docente: El docente con el id: {docente.Id} ya existe.");
            }

            var result = await _context.Docentes.AddAsync(docente);

            await _context.SaveChangesAsync();

            return result.Entity;
        }

        public async Task<List<Docente>> GetAsync()
        {
            return await _context.Docentes
            .ToListAsync();
        }
    }
}
