using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Collections.Generic;
using System.Linq;
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
        IMobileServiceTable<Campania> _CampaniaTable;
        List<Campania> campanias;
        AzureConnection AzureClient = new AzureConnection();
        bool isInitialized;

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
            await InitializeAsync();

            _CampaniaTable = AzureClient.Client.GetTable<Campania>();
            //campanias = await _CampaniaTable.ToListAsync();
            isInitialized = true;

            return campanias;
        }

        public async Task InitializeAsync()
        {
            if (isInitialized)
                return;

            campanias = new List<Campania>();
            var _items = new List<Campania>
            {
                new Campania { CampaniaId = 1, Nombre = "YA ESTA", Descripcion="The cats are hungry"},
                new Campania { CampaniaId = 2, Nombre = "VALIENDO", Descripcion="The cats are angry"},
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
