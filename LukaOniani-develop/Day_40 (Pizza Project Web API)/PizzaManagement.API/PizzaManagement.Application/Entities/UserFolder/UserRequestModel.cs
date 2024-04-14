﻿

using PizzaManagement.Domain.Entity;

namespace PizzaManagement.Application.Entities.UserFolder
{
    public class UserRequestModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public List<Address> Addresses { get; set; }
    }
}
