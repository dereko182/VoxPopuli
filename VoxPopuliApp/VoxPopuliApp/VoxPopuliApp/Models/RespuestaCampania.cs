namespace VoxPopuliApp.Models
{
    public class RespuestaCampania
    {
        public int RespuestaCampaniaId { get; set; }
        public int CampaniaDetalleId { get; set; }
        public int RespuestaId { get; set; }
        public byte OpcionRespuesta { get; set; }
        public string Comentarios { get; set; }
        public DateTime Fecha { get; set; }
    }
}
