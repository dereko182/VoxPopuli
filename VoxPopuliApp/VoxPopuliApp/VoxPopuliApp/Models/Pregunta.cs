using System;
using System.Collections.Generic;

namespace VoxPopuliApp.Models
{
    public class Pregunta
    {
        public Pregunta()
        {
            this.CampaniaDetalles = new List<CampaniaDetalle>();
        }

        public int PreguntaId { get; set; }
        public string Nombre { get; set; }
        public DateTime Fecha { get; set; }
        public int TipoControlId { get; set; }

        public List<CampaniaDetalle> CampaniaDetalles { get; set; }
    }
}
