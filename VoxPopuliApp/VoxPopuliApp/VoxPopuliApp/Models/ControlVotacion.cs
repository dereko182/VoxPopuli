using System;
using System.Collections.Generic;

namespace VoxPopuliApp.Models
{
    public class ControlVotacion
    {
        public int CampaniaId { get; set; }
        public string DeviceId { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }
        public DateTime Fecha { get; set; }

        public Campania Campania { get; set; }
    }
}
