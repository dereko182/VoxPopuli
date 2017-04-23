using System;
using System.Collections.Generic;

namespace VoxPopuliApp.Models
{
    public class Campania
    {
        public Campania()
        {
            this.CampaniaDetalles = new List<CampaniaDetalle>();
            this.ControlVotacions = new List<ControlVotacion>();
        }

        public int CampaniaId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public byte Estatus { get; set; }
        public int TipoCampaniaId { get; set; }
        public DateTime FechaInicia { get; set; }
        public DateTime FechaFinaliza { get; set; }

        public TipoCampania TipoCampania { get; set; }
        public TipoCampania TipoCampania1 { get; set; }
        public List<CampaniaDetalle> CampaniaDetalles { get; set; }
        public List<ControlVotacion> ControlVotacions { get; set; }
    }
}
