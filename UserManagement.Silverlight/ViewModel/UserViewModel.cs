using UserManagement.Silverlight.ServiceReference1;

namespace UserManagement.Silverlight.ViewModel
{
    public class UserViewModel
    {
        private readonly UserDto _userDto;

        public UserViewModel(UserDto userDto)
        {
            _userDto = userDto;
        }

        public int Id
        {
            get
            {
                return _userDto.Id;
            }
        }

        public string UserName
        {
            get
            {
                return string.Format("{0} {1}", _userDto.FirstName, _userDto.LastName);
            }
        }
    }
}