using VoxPopuliApp.Models;

namespace VoxPopuliApp.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public Campania Item { get; set; }
        public ItemDetailViewModel(Campania item = null)
        {
            Title = item.Nombre;
            Item = item;
        }

        int quantity = 1;
        public int Quantity
        {
            get { return quantity; }
            set { SetProperty(ref quantity, value); }
        }
    }
}