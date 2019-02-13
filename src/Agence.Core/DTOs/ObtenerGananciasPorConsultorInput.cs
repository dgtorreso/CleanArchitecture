using System;

namespace Agence.Core.DTOs
{
    public class ObtenerGananciasPorConsultorInput
    {
        public string[] consultorIds { get; set; } = new string[0];

        public int DesdeMes { get; set; }
        public int DesdeAnio { get; set; }
        public int HastaMes { get; set; }
        public int HastaAnio { get; set; }
    }
}
