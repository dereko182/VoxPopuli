using Microsoft.WindowsAzure.MobileServices;

namespace VoxPopuliApp.Helpers
{
    public class AzureConnection
    {        
        MobileServiceClient client;

        public AzureConnection()
        {
            client = new MobileServiceClient(@"http://voxpopuliapp.azurewebsites.net/");            
        }
    }
}
