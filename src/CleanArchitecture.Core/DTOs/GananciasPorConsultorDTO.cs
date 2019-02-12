using System.Collections.Generic;

namespace CleanArchitecture.Core.DTOs
{
    public class GananciasPorConsultorDTO
    {
        public string ConsultorId { get; set; }
        public string Nombre { get; set; }
        public List<GananciasPorConsultorDetalleDTO> Detalle { get; set; }
    }
}
