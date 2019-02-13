using System.Collections.Generic;

namespace Agence.Core.DTOs
{
    public class GananciasPorConsultorDTO
    {
        public string ConsultorId { get; set; }
        public string Nombre { get; set; }
        public List<GananciasPorConsultorDetalleDTO> Detalle { get; set; }
    }
}
