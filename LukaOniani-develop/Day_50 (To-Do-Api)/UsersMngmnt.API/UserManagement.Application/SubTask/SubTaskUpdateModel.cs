
using UserManagement.Domain;
using static UserManagement.Domain.Enums;

namespace UserManagement.Application.SubTask
{
    public class SubTaskUpdateModel
    {
        public string Title { get; set; }
        public int TodoItemId { get; set; }
        public Status Status { get; set; }
    }
}
