using UserManagement.WPF.ServiceReference1;

namespace UserManagement.WPF
{
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();

            UserManagementExposedServiceClient client = new UserManagementExposedServiceClient();

            UserDto userdetails = client.GetUserdetails(1);

            DataContext = userdetails;
        }
    }
}