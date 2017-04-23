using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using VoxPopuliApp.Helpers;
using VoxPopuliApp.Models;
using Xamarin.Forms;

namespace VoxPopuliApp.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public Rootobject Item { get; set; }
        public ObservableRangeCollection<Respuesta> Respuestas { get; set; }
        public Command CargaRespuesta { get; set; }
        public Command CargarSiguiente { get; set; }
        private int index = 0;
        private int TipoCampania;
        private string textoBoton;

        public Respuesta respuestaSeleccionada;

        public ItemDetailViewModel(Rootobject item = null)
        {
            Title = item.CampaniaDetalle.First().Pregunta.Nombre;
            Item = item;
            TipoCampania = item.CampaniaId;
            TextoBoton = "Siguiente";
            Respuestas = new ObservableRangeCollection<Respuesta>();
            CargaRespuesta = new Command(async () => await ExecuteLoadRespuestasCommand());
            CargarSiguiente = new Command(() => ExecuteCargaSiguienteCommand());
        }

        private void ExecuteCargaSiguienteCommand()
        {
            if (index < Item.CampaniaDetalle.Count() - 1)
            {
                insertarRespuesta();
                index++;
                Respuestas.Clear();
                Title = Item.CampaniaDetalle[index].Pregunta.Nombre;
                GetRespuestas(); 
            }
            else if (index == Item.CampaniaDetalle.Count() - 1)
            {
                TextoBoton = "Final";
            }
        }
        private void insertarRespuesta()
        {

        }
        private async Task ExecuteLoadRespuestasCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                Respuestas.Clear();
                GetRespuestas();
                //List<Respuesta> respuestas = GetRespuestas();
                //Respuestas.ReplaceRange(respuestas);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                MessagingCenter.Send(new MessagingCenterAlert
                {
                    Title = "Error",
                    Message = "Imposible cargar campañas.",
                    Cancel = "Aceptar"
                }, "Aviso");
            }
            finally
            {
                IsBusy = false;
            }
        }

        private List<Respuesta> GetRespuestas()
        {
            List<ListView> preguntas = new List<ListView>();
            List<Campaniadetalle> companiasdetalle = Item.CampaniaDetalle.ToList();
            companiasdetalle = companiasdetalle.Where(w => w.CampaniaId == TipoCampania).ToList();
            List<Respuesta> respuestasOut = null;

            Label resp = new Label();
            foreach (Controlpregunta item in companiasdetalle[index].Pregunta.ControlPregunta)
            {
                Respuestas.Add(item.Respuesta);
            }
            return respuestasOut;
        }

        int quantity = 1;
        public int Quantity
        {
            get { return quantity; }
            set { SetProperty(ref quantity, value); }
        }

        public string TextoBoton
        {
            get
            {
                return textoBoton;
            }

            set
            {                
                SetProperty(ref textoBoton, value);
            }
        }
    }
}