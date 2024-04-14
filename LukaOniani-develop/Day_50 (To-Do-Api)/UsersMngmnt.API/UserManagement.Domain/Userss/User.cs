using UserManagement.Domain.TO_DOs;
using static UserManagement.Domain.Enums;

namespace UserManagement.Domain.Userss
{
    public class Userss
    {  
        public int Id { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        public Status Status { get; set; }

        // navigation
        public List<ToDos> ToDoes { get; set; }
      
    }
 
}
