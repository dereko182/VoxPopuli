using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VoxPopuliApp.Models
{
    public class Campania
    {
        public Campania()
        {
            this.CampaniaDetalles = new List<CampaniaDetalle>();
        }
        
        [JsonProperty("id")]
        public int CampaniaId { get; set; }
        [JsonProperty("nombre")]
        public string Nombre { get; set; }
        [JsonProperty("descripcion")]
        public string Descripcion { get; set; }
        [JsonProperty("estatus")]
        public byte Estatus { get; set; }
        [JsonProperty("fechainicia")]
        public DateTime FechaInicia { get; set; }
        [JsonProperty("fechafinaliza")]
        public DateTime FechaFinaliza { get; set; }

        public List<CampaniaDetalle> CampaniaDetalles { get; set; }
    }
}
