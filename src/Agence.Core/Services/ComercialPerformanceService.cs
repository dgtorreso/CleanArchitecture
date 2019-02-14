using System.Collections.Generic;
using Ardalis.GuardClauses;
using Agence.Core.DTOs;
using Agence.Core.Events;
using Agence.Core.Interfaces;
using Agence.Core.Interfaces.Services;
using System.Linq;
using Agence.Core.Entities;
using System;

namespace Agence.Core.Services
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
            var usuarios = this.repository.Consultar<cao_usuario>().Where(a => input.consultorIds.Contains(a.co_usuario)).ToList();
            var oss = this.repository.Consultar<cao_os>().Where(a=> input.consultorIds.Contains(a.co_usuario)).ToList();
            var osIds = oss.Select(a => a.co_os).ToList();
            var facturas = this.repository.Consultar<cao_fatura>()
                .Where(a => osIds.Contains(a.co_os) && a.data_emissao >= desde && a.data_emissao <= hasta).ToList();
            var salarios = this.repository.Consultar<cao_salario>().Where(a => input.consultorIds.Contains(a.co_usuario)).ToList();
            facturas.ForEach(a=> a.Os = oss.First(b=> b.co_os == a.co_os));
            oss.ForEach(a=> a.Cao_Usuario = usuarios.First(b=> b.co_usuario == a.co_usuario));
            var consulta = facturas.Select(a => new
                {
                    receita_liquida = a.valor * (a.total_imp_inc / 100),
                    fecha = a.data_emissao,
                    comision = (a.valor - (a.valor * (a.total_imp_inc / 100))) * (a.comissao_cn / 100),
                    ConsultorId = a.Os.co_usuario,
                    ConsultorDesc = a.Os.Cao_Usuario.no_usuario,
                    Salario = salarios.FirstOrDefault(b=> b.co_usuario == a.Os.co_usuario)?.brut_salario ?? 0,
                });

            return consulta.GroupBy(a => new { a.ConsultorId, a.ConsultorDesc })
                .Select(a => new GananciasPorConsultorDTO
                {
                    ConsultorId = a.Key.ConsultorId,
                    Nombre = a.Key.ConsultorDesc,
                    Comision = a.Sum(b=>b.comision),
                    Lucro = a.Sum(b=> b.Salario + b.comision),
                    ReceitaLiquida = a.Sum(b=>b.receita_liquida),
                    Salario = a.Sum(b=>b.Salario),
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

