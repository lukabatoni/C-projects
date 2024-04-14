using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagement.Domain.TO_DOs;
using static UserManagement.Domain.Enums;

namespace UserManagement.Domain.SubTask
{
    public class Subtask
    {
        public int Id { get; set; } 
        public string Title { get; set; }   
        public int TodoItemId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        public Status Status { get; set; }

        //navigate

        public ToDos ToDos { get; set; }
    }
}
