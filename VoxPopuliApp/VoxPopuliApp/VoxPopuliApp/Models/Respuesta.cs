using System;

namespace VoxPopuliApp.Models
{
    public class Respuesta
    {
        public int RespuestaId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
    }
}
