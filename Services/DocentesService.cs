using AutoMapper;
using Microsoft.AspNetCore.Http;
using RestDocentesAPI.Data.DTO;
using RestDocentesAPI.Data.Entities;
using RestDocentesAPI.Data.Repositories;
using System.Data;

namespace RestDocentesAPI.Services
{
    public class DocentesService : IDocentesService
    {
        private readonly ILogger<DocentesService> _logger;
        private readonly IMapper _mapper;
        private readonly IDocentesRepository _docentesRepository;
        public DocentesService(
        ILogger<DocentesService> logger,
        IMapper mapper,
        IDocentesRepository docentesRepository)
        {
            _logger = logger;
            _mapper = mapper;
            _docentesRepository = docentesRepository;
        }

        public async Task<List<Docente>> GetDocentes()
        {
            _logger.LogInformation("Microservicios docentes: Getting docentes...");
            var docentes = await _docentesRepository.GetAsync();

            if (docentes is null)
            {
                throw new Exception($"No se encontraron docentes.");
            }

            return docentes;
        }

        public async Task<Docente> AddDocente(Docente request)
        {
            _logger.LogInformation("Microservicios docentes: Adding docente...");
            var newDocente = request;


            if (newDocente.Id is null)
            {
                throw new Exception("Please provide Docente Id.");
            }

            if (newDocente.Nombre is null)
            {
                throw new Exception("Please provide Nombre Docente.");
            }

            try
            {
                var docente = await _docentesRepository.AddAsync(_mapper.Map<Docente>(newDocente));

                return docente;
            }
            catch (DataException e)
            {
                throw new Exception(e.Message);
            }
            catch (Exception)
            {
                throw new Exception("Unknown error.");
            }
        }
    }
}
