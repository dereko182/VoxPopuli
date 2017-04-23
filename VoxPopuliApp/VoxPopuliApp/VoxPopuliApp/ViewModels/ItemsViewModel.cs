using System;
using System.Diagnostics;
using System.Threading.Tasks;

using VoxPopuliApp.Helpers;
using VoxPopuliApp.Models;
using VoxPopuliApp.Views;

using Xamarin.Forms;

namespace VoxPopuliApp.ViewModels
{
    public class ItemsViewModel : BaseViewModel
    {
        public ObservableRangeCollection<Item> Items { get; set; }
        public ObservableRangeCollection<Campania> Campanias { get; set; }
        public Command LoadItemsCommand { get; set; }
        public Command CargaCampanias { get; set; }

        public ItemsViewModel()
        {
            #region [Original]
            //Title = "Campañas Activas";
            //Items = new ObservableRangeCollection<Item>();
            //LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());

            //MessagingCenter.Subscribe<NewItemPage, Item>(this, "AddItem", async (obj, item) =>
            //{
            //    var _item = item as Item;
            //    Items.Add(_item);
            //    await DataStore.AddItemAsync(_item);
            //});
            #endregion

            Title = "Campañas Activas";
            Campanias = new ObservableRangeCollection<Campania>();
            CargaCampanias = new Command(async () => await ExecuteLoadCampaniasCommand());
        }

        async Task ExecuteLoadCampaniasCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                Campanias.Clear();
                var campanias = await CampaniaStore.GetItemsAsync(true);
                Campanias.ReplaceRange(campanias);
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

        //async Task ExecuteLoadItemsCommand()
        //{
        //    if (IsBusy)
        //        return;

        //    IsBusy = true;

        //    try
        //    {
        //        Items.Clear();
        //        var items = await DataStore.GetItemsAsync(true);
        //        Items.ReplaceRange(items);
        //    }
        //    catch (Exception ex)
        //    {
        //        Debug.WriteLine(ex);
        //        MessagingCenter.Send(new MessagingCenterAlert
        //        {
        //            Title = "Error",
        //            Message = "Imposible cargar campañas.",
        //            Cancel = "Aceptar"
        //        }, "Aviso");
        //    }
        //    finally
        //    {
        //        IsBusy = false;
        //    }
        //}
    }
}