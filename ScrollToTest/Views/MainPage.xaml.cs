using ScrollToTest.Models;
using ScrollToTest.ViewModels;
using System.Linq;

namespace ScrollToTest.Views
{
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            MainPageViewModel viewModel = BindingContext as MainPageViewModel;
            State model = viewModel.States.FirstOrDefault(m => m.StateName == "Texas");
            collectionView.ScrollTo(model);
        }
    }
}
