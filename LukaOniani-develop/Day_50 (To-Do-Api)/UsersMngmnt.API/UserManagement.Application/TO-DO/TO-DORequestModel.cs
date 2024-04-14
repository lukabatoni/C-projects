using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagement.Domain;
using UserManagement.Domain.SubTask;

namespace UserManagement.Application.TO_DO
{
    public class TO_DORequestModel
    {
        public string Title { get; set; }
        public string Status { get; set; }
        public DateTime? TargetCompletionDate { get; set; }
        public int OwnerId { get; set; }
    }
}
