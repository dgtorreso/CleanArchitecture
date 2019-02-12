using System.Collections.Generic;
using Ardalis.GuardClauses;
using CleanArchitecture.Core.DTOs;
using CleanArchitecture.Core.Events;
using CleanArchitecture.Core.Interfaces;
using CleanArchitecture.Core.Interfaces.Services;
using System.Linq;
using CleanArchitecture.Core.Entities;
using System;

namespace CleanArchitecture.Core.Services
{
    public class ComercialPerformanceService : IComercialPerformanceService
    {
        private readonly IRepository repository;

        public ComercialPerformanceService(IRepository repository)
        {
            this.repository = repository;
        }
        public IEnumerable<ClienteDTO> ObternerClientes()
        {
            return this.repository.Consultar<cao_cliente>().Select(a => new ClienteDTO { Id = a.co_cliente, Descripcion = a.no_fantasia });
        }

        public IEnumerable<ConsultorDTO> ObternerConsultores()
        {
            var tipos = new[] { 0m, 1m, 2m };
            return this.repository.Consultar<cao_usuario>().Where(a => a.permissao_sistema.Any(b => b.co_sistema == 1 && b.in_ativo == "S" && tipos.Contains(b.co_tipo_usuario)))
                .Select(a => new ConsultorDTO { Id = a.co_usuario, Nombre = a.no_usuario });
        }

        public IEnumerable<GananciasPorConsultorDTO> ObtenerGananciasPorConsultor(ObtenerGananciasPorConsultorInput input)
        {
            var desde = new DateTime(input.DesdeAnio, input.DesdeMes, 1);
            var hasta = new DateTime(input.HastaAnio, input.HastaMes, 1).AddMonths(1);
            var consulta = this.repository.Consultar<cao_fatura>()
                .Where(a => input.consultorIds.Contains(a.Cao_Os.co_usuario) && a.data_emissao >= desde && a.data_emissao <= hasta).Select(a => new
                {
                    receita_liquida = a.valor * (a.total_imp_inc / 100),
                    fecha = a.data_emissao,
                    comision = (a.valor - (a.valor * (a.total_imp_inc / 100))) * (a.comissao_cn / 100),
                    ConsultorId = a.Cao_Os.co_usuario,
                    ConsultorDesc = a.Cao_Os.Cao_Usuario.no_usuario,
                    Salario = a.Cao_Os.Cao_Usuario.Cao_Salarios.FirstOrDefault().brut_salario,
                });

            return consulta.GroupBy(a => new { a.ConsultorId, a.ConsultorDesc })
                .Select(a => new GananciasPorConsultorDTO
                {
                    ConsultorId = a.Key.ConsultorId,
                    Nombre = a.Key.ConsultorDesc,
                    Detalle = a.GroupBy(b => new { b.fecha.Month, b.fecha.Year })
                    .Select(b => new GananciasPorConsultorDetalleDTO
                    {
                        ReceitaLiquida = b.Sum(c => c.receita_liquida),
                        Comision = b.Sum(c => c.comision),
                        Salario = b.Sum(c => c.Salario),
                        Lucro = b.Sum(c => c.Salario + c.comision),
                        Mes = b.Key.Month,
                        Anio = b.Key.Year
                    }).ToList()
                });
        }
    }



}

