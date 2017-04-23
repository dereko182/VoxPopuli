namespace VoxPopuliApp.Models
{
    public class TipoCampania
    {
        public TipoCampania()
        {
            this.Campanias = new List<Campania>();
            this.Campanias1 = new List<Campania>();
        }

        public int TipoCampaniaId { get; set; }
        public string Nombre { get; set; }
        public DateTime Fecha { get; set; }

        public List<Campania> Campanias { get; set; }
        public List<Campania> Campanias1 { get; set; }
    }
}
