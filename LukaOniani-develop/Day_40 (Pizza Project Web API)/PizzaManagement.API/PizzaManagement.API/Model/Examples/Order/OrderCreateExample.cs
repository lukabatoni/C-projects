﻿using PizzaManagement.API.Model.Requests;
using Swashbuckle.AspNetCore.Filters;

namespace PizzaManagement.API.Model.Examples.Order
{
    public class OrderCreateExample : IExamplesProvider<OrderCreateModel>
    {
        public OrderCreateModel GetExamples()
        {
            return new OrderCreateModel()
            { 
                UserId = 1,
                AddressId = 2,
                Pizza = new List<Domain.Entity.Pizza> { 
                        new Domain.Entity.Pizza { 
                            Id = 1, 
                            Name = "Proschutto", 
                            Price = 17, 
                            Description = "Pizza with bacon and cheese.", 
                            CaloryCount = 1200 
                        } 
                },
                RankHistory = new List<Domain.Entity.RankHistory> { 
                    new Domain.Entity.RankHistory { 
                        UserId = 1, 
                        PizzaId = 1, 
                        Rank = 5 }, 
                    new Domain.Entity.RankHistory { 
                        UserId = 1, 
                        PizzaId = 3, 
                        Rank = 3 
                    } 
                }
            };
        }
    }
}
