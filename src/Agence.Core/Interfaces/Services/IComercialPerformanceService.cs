using Agence.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Agence.Core.Interfaces.Services
{
    public interface IComercialPerformanceService
    {
        IEnumerable<ClienteDTO> ObternerClientes();
        IEnumerable<ConsultorDTO> ObternerConsultores();
        IEnumerable<GananciasPorConsultorDTO> ObtenerGananciasPorConsultor(ObtenerGananciasPorConsultorInput input);
    }
}
