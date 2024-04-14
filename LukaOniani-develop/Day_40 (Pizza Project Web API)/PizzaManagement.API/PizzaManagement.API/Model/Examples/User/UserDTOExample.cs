using PizzaManagement.API.Model.DTO;
using Swashbuckle.AspNetCore.Filters;

namespace PizzaManagement.API.Model.Examples.User
{
    public class UserDTOExample : IExamplesProvider<UserResponseDTO>
    {
        public UserResponseDTO GetExamples()
        {
            return new UserResponseDTO()
            {
                Id = 1,
                FirstName = "Luka",
                LastName = "Oniani",
                Email = "oniani.luka@kiu.edu.ge",
                PhoneNumber = "568400222",
                AddressIds = new List<int> { 1 }
            };
        }
    }

}
