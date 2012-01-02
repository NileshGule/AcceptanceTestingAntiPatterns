using System;
using System.Collections.Generic;

using UserManagementService.DataTransferObjects;

namespace AntiPattern1.FitnesseFixtures
{
    public class UserFixture
    {
        public List<Object> Query()
        {
            UserManagementServices.UserManagementService service = new UserManagementServices.UserManagementService();

            UserDto userdetails = service.GetUserdetails(1);

            return new List<Object>
                {
                    new List<object>
                        {
                            new List<string> { "Id", userdetails.Id.ToString() },
                            new List<object> { "FirstName", userdetails.FirstName },
                            new List<object> { "LastName", userdetails.LastName }
                        }
                };
        }
    }
}