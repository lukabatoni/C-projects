using UserManagement.Domain.SubTask;
using UserManagement.Domain.Userss;
using static UserManagement.Domain.Enums;




namespace UserManagement.Domain.TO_DOs
{
    public class ToDos
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Status { get; set; } 
        public DateTime? TargetCompletionDate { get; set; }
        public int OwnerId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        public Status StatusEnum { get; set; }

        //navigate
        public Userss.Userss userss { get; set; }
        public List<Subtask> Subtasks { get; set; }

    }
}
