
using VoxPopuliApp.Models;
using VoxPopuliApp.ViewModels;

using Xamarin.Forms;

namespace VoxPopuliApp.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        ItemDetailViewModel viewModel;

        // Note - The Xamarin.Forms Previewer requires a default, parameterless constructor to render a page.
        public ItemDetailPage()
        {
            InitializeComponent();
        }

        public ItemDetailPage(Item viewModel)
        {
            InitializeComponent();
            switch (viewModel.Tipo)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
            }
        }
    }
}
