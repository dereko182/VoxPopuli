using System;
using System.Collections.Generic;

namespace VoxPopuliApp.Models
{
    public class Respuesta
    {
        public Respuesta()
        {
            this.ControlPreguntas = new List<ControlPregunta>();
        }

        public int RespuestaId { get; set; }
        public string Respuesta { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }

        public List<ControlPregunta> ControlPreguntas { get; set; }
    }
}
