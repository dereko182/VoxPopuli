using System;
using System.Collections.Generic;

namespace VoxPopuliApp.Models
{
    public class TipoControl
    {
        public TipoControl()
        {
            this.Preguntas = new List<Pregunta>();
        }

        public int TipoControlId { get; set; }
        public string Nombre { get; set; }
        public DateTime Fecha { get; set; }

        public List<Pregunta> Preguntas { get; set; }
    }
}
