using System.Windows.Navigation;

using UserManagement.Silverlight.ServiceReference1;
using UserManagement.Silverlight.ViewModel;

namespace UserManagement.Silverlight
{
    public partial class Home
    {
        public Home()
        {
            InitializeComponent();
            Loaded += Home_Loaded;
        }

        private void Home_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            UserManagementExposedServiceClient client = new UserManagementExposedServiceClient();

            client.GetUserdetailsCompleted += (o, args) => client_GetUserdetailsCompleted(o, args);

            client.GetUserdetailsAsync(10);
        }

        private void client_GetUserdetailsCompleted(object sender, GetUserdetailsCompletedEventArgs args)
        {
            UserDto userDto = args.Result;

            UserViewModel viewModel = new UserViewModel(userDto);

            DataContext = viewModel;
        }

        // Executes when the user navigates to this page.
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }
    }
}