﻿using PizzaManagement.API.Model.DTO;
using Swashbuckle.AspNetCore.Filters;

namespace PizzaManagement.API.Model.Examples.User
{
    public class UserDTOListExample : IExamplesProvider<List<UserResponseDTO>>
    {
        public List<UserResponseDTO> GetExamples()
        {
            return new List<UserResponseDTO>()
            {
                new UserResponseDTO {
                    Id = 1,
                    FirstName = "Luka",
                LastName = "Oniani",
                Email = "oniani.luka@kiu.edu.ge",
                PhoneNumber = "568400222",
                    AddressIds = new List<int> { 1 }
                }
            };
        }
    }
}
