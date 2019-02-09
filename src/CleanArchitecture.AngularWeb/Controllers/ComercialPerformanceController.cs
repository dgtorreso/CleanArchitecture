using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArchitecture.Core.Entities;
using CleanArchitecture.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.AngularWeb.Controllers
{
    [Route("api/[controller]")]
    public class ComercialPerformanceController : Controller
    {
        private readonly IRepository repository;

        public ComercialPerformanceController(IRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet("[action]")]
        public IEnumerable<cao_atividade> GetAtividades()
        {
            return repository.List<cao_atividade>();
        }
    }
}
