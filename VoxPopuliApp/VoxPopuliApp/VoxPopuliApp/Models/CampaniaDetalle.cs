using System;

namespace VoxPopuliApp.Models
{
    public class CampaniaDetalle
    {
        public int CampaniaDetalleId { get; set; }
        public int CampaniaId { get; set; }
        public int PreguntaId { get; set; }
        public DateTime Fecha { get; set; }
        public int Orden { get; set; }

        public Campania Campania { get; set; }
        public Pregunta Pregunta { get; set; }
    }
}
