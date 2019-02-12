using CleanArchitecture.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Core.Interfaces.Services
{
    public interface IComercialPerformanceService
    {
        IEnumerable<ClienteDTO> ObternerClientes();
        IEnumerable<ConsultorDTO> ObternerConsultores();
        IEnumerable<GananciasPorConsultorDTO> ObtenerGananciasPorConsultor(ObtenerGananciasPorConsultorInput input);
    }
}
