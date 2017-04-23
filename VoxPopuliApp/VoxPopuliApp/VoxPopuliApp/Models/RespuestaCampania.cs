using System;

namespace VoxPopuliApp.Models
{
    public class RespuestaCampania
    {
        public int CampaniaDetalleId { get; set; }
        public int CampaniaId { get; set; }
        public int RespuestaId { get; set; }
        public byte OpcionRespuesta { get; set; }
        public int ContadorRespuesta { get; set; }
        public string Comentarios { get; set; }
        public DateTime Fecha { get; set; }
    }
}
