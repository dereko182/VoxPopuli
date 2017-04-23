using Microsoft.WindowsAzure.MobileServices;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using VoxPopuliApp.Helpers;
using VoxPopuliApp.Models;
using Xamarin.Forms;

[assembly: Dependency(typeof(VoxPopuliApp.Services.CampaniaDataStore))]
namespace VoxPopuliApp.Services
{
    public class CampaniaDataStore : IDataStore<Campania>
    {
        HttpClient client;
        IMobileServiceTable<Campania> _CampaniaTable;
        List<Campania> campanias;
        AzureConnection AzureClient = new AzureConnection();
        bool isInitialized;

        public CampaniaDataStore()
        {
            client = new HttpClient();
            client.MaxResponseContentBufferSize = 256000;
        }

        public Task<bool> AddItemAsync(Campania item)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteItemAsync(Campania item)
        {
            throw new NotImplementedException();
        }

        public Task<Campania> GetItemAsync(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Campania>> GetItemsAsync(bool forceRefresh = false)
        {
            try
            {
                //await InitializeAsync();
                campanias = new List<Campania>();

                string RestUrl = @"http://192.168.1.18/voxpopuli/api/Campanias";

                var uri = new Uri(string.Format(RestUrl, string.Empty));

                var response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    List<Rootobject> data = JsonConvert.DeserializeObject<List<Rootobject>>(content);                                  
                    campanias = JsonConvert.DeserializeObject<List<Campania>>(content);
                }

                isInitialized = true;
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

            return campanias;
        }

        public async Task InitializeAsync()
        {
            //if (isInitialized)
            //    return;

            //            campanias = new List<Campania>();
            var _items = new List<Campania>
            {
                new Campania { CampaniaId = 1, Nombre = "PRUEBA 1", Descripcion="TODOITEM"},
                new Campania { CampaniaId = 2, Nombre = "PRUEBA 2", Descripcion="TODOITEM"},
            };

            foreach (Campania item in _items)
            {
                campanias.Add(item);
            }

            isInitialized = true;
        }

        public Task<bool> PullLatestAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> SyncAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateItemAsync(Campania item)
        {
            throw new NotImplementedException();
        }
    }
}
