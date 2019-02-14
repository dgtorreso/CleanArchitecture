using System.Collections.Generic;

namespace Agence.Core.DTOs
{
    public class GananciasPorConsultorDTO
    {
        public string ConsultorId { get; set; }
        public string Nombre { get; set; }

        public float ReceitaLiquida { get; set; }
        public float Comision { get; set; }
        public float Salario { get; set; }
        public float Lucro { get; set; }

        public List<GananciasPorConsultorDetalleDTO> Detalle { get; set; }
    }
}
