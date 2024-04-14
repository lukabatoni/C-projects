using PizzaManagement.API.Model.Requests;
using Swashbuckle.AspNetCore.Filters;

namespace PizzaManagement.API.Model.Examples.User
{
    public class UserCreateExample : IExamplesProvider<UserCreateModel>
    {
        public UserCreateModel GetExamples()
        {
            return new UserCreateModel()
            {
                FirstName = "Luka", 
                LastName = "Oniani", 
                Email = "oniani.luka@kiu.edu.ge", 
                PhoneNumber = "568400222", 
                Addresses = new List<Domain.Entity.Address> {
                    new Domain.Entity.Address { Id = 1, UserId = 1,
                        City = "Kutaisi", Country = "Georgia",
                        Region = "Imereti", Description = "Baratashvili street"
                    }
                }
            };
        }
    }
}
