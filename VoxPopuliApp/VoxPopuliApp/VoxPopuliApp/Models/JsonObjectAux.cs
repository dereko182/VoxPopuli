using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoxPopuliApp.Models
{
    public class Rootobject
    {
        public object[] ControlVotacion { get; set; }
        public Campaniadetalle[] CampaniaDetalle { get; set; }
        public int CampaniaId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Estatus { get; set; }
        public int TipoCampaniaId { get; set; }
        public DateTime FechaInicia { get; set; }
        public DateTime FechaFinaliza { get; set; }
    }

    public class Campaniadetalle
    {
        public Pregunta Pregunta { get; set; }
        public object[] RespuestaCampania { get; set; }
        public int CampaniaDetalleId { get; set; }
        public int CampaniaId { get; set; }
        public int PreguntaId { get; set; }
        public int Orden { get; set; }
        public DateTime Fecha { get; set; }
    }

    public class Pregunta
    {
        public object[] CampaniaDetalle { get; set; }
        public Tipocontrol TipoControl { get; set; }
        public int PreguntaId { get; set; }
        public string Nombre { get; set; }
        public DateTime Fecha { get; set; }
        public int TipoControlId { get; set; }
    }

    public class Tipocontrol
    {
        public int TipoControlId { get; set; }
        public string Nombre { get; set; }
        public DateTime Fecha { get; set; }
    }

    public class Controlpregunta
    {
        public Respuesta Respuesta { get; set; }
        public int PreguntaId { get; set; }
        public int RespuestaId { get; set; }
        public int Orden { get; set; }
        public DateTime Fecha { get; set; }
    }

    public class Respuesta
    {
        public object[] ControlPregunta { get; set; }
        public object[] RespuestaCampania { get; set; }
        public int RespuestaId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
    }
}
