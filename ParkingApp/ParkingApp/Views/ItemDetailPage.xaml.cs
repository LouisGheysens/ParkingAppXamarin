using ParkingApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace ParkingApp.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}