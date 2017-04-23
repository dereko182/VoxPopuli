using System;

namespace VoxPopuliApp.Models
{
    public class ControlPregunta
    {
        public int PreguntaId { get; set; }
        public int RespuestaId { get; set; }
        public int Orden { get; set; }
        public DateTime Fecha { get; set; }
    }
}
