using UserManagement.Domain;
using UserManagement.Domain.SubTask;
using static UserManagement.Domain.Enums;

namespace UserManagement.Application.TO_DO
{
    public class TO_DOResponseModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Status { get; set; }
        public DateTime? TargetCompletionDate { get; set; }
        public int OwnerId { get; set; }


        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        public Status StatusEnum { get; set; }
    }
}
