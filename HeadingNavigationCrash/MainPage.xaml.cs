using HeadingNavigationCrash.ViewModels;

namespace HeadingNavigationCrash
{
    public partial class MainPage : ContentPage
    {
        private MainViewModel ViewModel { get; set; }

        public MainPage()
        {
            InitializeComponent();

            ViewModel = new MainViewModel();
            ViewModel.InitItems();
            BindingContext = ViewModel;
        }
        
    }
}
