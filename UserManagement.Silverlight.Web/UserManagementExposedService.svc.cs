using System.ServiceModel;
using System.ServiceModel.Activation;

using UserManagementService.DataTransferObjects;

namespace UserManagement.Silverlight.Web
{
    [ServiceContract(Namespace = "")]
    [SilverlightFaultBehavior]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class UserManagementExposedService
    {
        [OperationContract]
        public UserDto GetUserdetails(int userId)
        {
            UserManagementServices.UserManagementService service = new UserManagementServices.UserManagementService();

            return service.GetUserdetails(userId);
        }
    }
}