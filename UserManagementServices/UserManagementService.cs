using UserManagementService.DataTransferObjects;
using UserManagementService.DomainObjects;

namespace UserManagementServices
{
    public class UserManagementService : IUserManagementService
    {
        public UserDto GetUserdetails(int userId)
        {
            User domainUser = new User
                {
                    Id = userId,
                    FirstName = "James",
                    LastName = "Bond"
                };

            return new UserDto
                {
                    Id = domainUser.Id,
                    FirstName = domainUser.FirstName,
                    LastName = domainUser.LastName
                };
        }
    }
}