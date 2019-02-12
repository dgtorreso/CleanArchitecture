using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArchitecture.Core.DTOs;
using CleanArchitecture.Core.Entities;
using CleanArchitecture.Core.Interfaces;
using CleanArchitecture.Core.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.AngularWeb.Controllers
{
    [Route("api/[controller]")]
    public class ComercialPerformanceController : Controller
    {
        private readonly IRepository repository;
        private readonly IComercialPerformanceService comercialPerformanceService;

        public ComercialPerformanceController(IRepository repository, IComercialPerformanceService comercialPerformanceService)
        {
            this.repository = repository;
            this.comercialPerformanceService = comercialPerformanceService;
        }

        [HttpGet("[action]")]
        public IEnumerable<cao_atividade> GetAtividades()
        {
            return repository.List<cao_atividade>();
        }

        [HttpGet("[action]")]
        public IEnumerable<ClienteDTO> ObtenerClientes()
        {
            var res = comercialPerformanceService.ObternerClientes().Take(10).ToList();
            return res;
        }

        [HttpGet("[action]")]
        public IEnumerable<ConsultorDTO> ObtenerConsultores()
        {
            var res = comercialPerformanceService.ObternerConsultores().Take(10).ToList();
            return res;
        }

        [HttpGet("[action]")]
        public IEnumerable<GananciasPorConsultorDTO> ObtenerGananciasPorConsultor(ObtenerGananciasPorConsultorInput input)
        {
            var res = comercialPerformanceService.ObtenerGananciasPorConsultor(input).ToList();

            return res;
        }

        
    }
}
