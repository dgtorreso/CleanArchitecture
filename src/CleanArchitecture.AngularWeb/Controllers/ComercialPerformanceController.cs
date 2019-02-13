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
            var res = comercialPerformanceService.ObternerClientes().Take(100).ToList();
            return res;
        }

        [HttpGet("[action]")]
        public IEnumerable<ConsultorDTO> ObtenerConsultores()
        {
            var res = comercialPerformanceService.ObternerConsultores().Take(100).ToList();
            return res;
        }

        [HttpGet("[action]")]
        public IEnumerable<GananciasPorConsultorDTO> ObtenerGananciasPorConsultor(ObtenerGananciasPorConsultorInput input)
        {
            var res = comercialPerformanceService.ObtenerGananciasPorConsultor(input).ToList();

            return res;
        }

        [HttpGet("[action]")]
        public ChartBarDTO ObtenerGananciasPorConsultorBar(ObtenerGananciasPorConsultorInput input)
        {
            var res = comercialPerformanceService.ObtenerGananciasPorConsultor(input).ToList();
            var desde = new DateTime(input.DesdeAnio, input.DesdeMes, 1);
            var hasta = new DateTime(input.HastaAnio, input.HastaMes, 1);
            var chart = new ChartBarDTO() { labels = new List<string>(), datasets = new List<Dataset>() };
            var listaMeses = new List<Tuple<int, int>>();
            while (desde < hasta)
            {
                listaMeses.Add(new Tuple<int, int>(desde.Month, desde.Year));
                chart.labels.Add(desde.ToString("MMMM De yyyy"));
                desde = desde.AddMonths(1);
            }
            foreach (var reg in res)
            {
                chart.datasets.Add(new Dataset
                {
                    label = reg.Nombre,
                    backgroundColor = ChartBarDTO.getRandomColor(),
                    data = listaMeses.Select(a => reg.Detalle.FirstOrDefault(b => b.Anio == a.Item2 && b.Mes == a.Item1)?.ReceitaLiquida ?? 0).ToList()
                });
            }
            chart.datasets.Add(new Dataset
            {
                label = "Fijo",
                type = "line",
                data = listaMeses.Select(a=> res.Average(con=> con.Detalle.FirstOrDefault(det=> det.Anio == a.Item2 && det.Mes == a.Item1)?.Salario ?? 0)).ToList()
            });
            return chart;
        }

        [HttpGet("[action]")]
        public ChartPieDTO ObtenerGananciasPorConsultorTorta(ObtenerGananciasPorConsultorInput input)
        {
            var res = comercialPerformanceService.ObtenerGananciasPorConsultor(input).ToList();
            var chart = new ChartPieDTO() { labels = new List<string>(), datasets = new List<DatasetPie>() };
            chart.labels = res.Select(a => a.Nombre).ToList();
            chart.datasets.Add(new DatasetPie
            {
                data = res.Select(a => a.Detalle.Sum(b => b.ReceitaLiquida)).ToList(),
                backgroundColor = res.Select(a => ChartBarDTO.getRandomColor()).ToList()
            });
            return chart;
        }
    }
}
