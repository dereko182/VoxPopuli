using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VoxPopuliApp.Helpers;
using VoxPopuliApp.Models;

namespace VoxPopuliApp.Services
{
    public class CampaniaDataStore : IDataStore<Campania>
    {
        bool isInitialized;
        IMobileServiceTable<Campania> _CampaniaTable;
        AzureConnection AzureClient = new AzureConnection();

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
            _CampaniaTable = AzureClient.Client.GetTable<Campania>();
            List<Campania> campanias = await _CampaniaTable.ToListAsync();
            isInitialized = true;

            return campanias;            
        }

        public Task InitializeAsync()
        {
            throw new NotImplementedException();
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
