

using UserManagement.Domain;
using static UserManagement.Domain.Enums;

namespace UserManagement.Application.Users
{
    public class UserUpdateModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public Status Status { get; set; }
    }
}
