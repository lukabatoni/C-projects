﻿using PizzaManagement.API.Model.Requests;
using Swashbuckle.AspNetCore.Filters;

namespace PizzaManagement.API.Model.Examples.Address
{
    public class AddressCreateExample : IExamplesProvider<AddressCreateModel>
    {
        public AddressCreateModel GetExamples()
        {
            return new AddressCreateModel()
            {
                UserId = 2,
                City = "Kutaisi",
                Country = "Georgia",
                Region = "Imereti",
                Description = "Villa"
            };
        }
    }
}
