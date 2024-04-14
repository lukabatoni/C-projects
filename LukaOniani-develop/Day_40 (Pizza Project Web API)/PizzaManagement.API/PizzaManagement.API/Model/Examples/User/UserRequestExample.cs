using PizzaManagement.Application.Entities.UserFolder;
using Swashbuckle.AspNetCore.Filters;

namespace PizzaManagement.API.Model.Examples.User
{
    public class UserRequestExample : IExamplesProvider<UserRequestModel>
    {
        public UserRequestModel GetExamples()
        {
            return new UserRequestModel()
            {
                Id = 1,
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
