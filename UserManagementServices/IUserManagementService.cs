using System.ServiceModel;

using UserManagementService.DataTransferObjects;

namespace UserManagementServices
{
    [ServiceContract]
    public interface IUserManagementService
    {
        [OperationContract]
        UserDto GetUserdetails(int userId);
    }
}