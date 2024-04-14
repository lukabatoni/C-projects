using PizzaManagement.API.Model.DTO;
using Swashbuckle.AspNetCore.Filters;

namespace PizzaManagement.API.Model.Examples.Order
{
    public class OrderDTOExample : IExamplesProvider<OrderResponseDTO>
    {
        public OrderResponseDTO GetExamples()
        {
            return new OrderResponseDTO()
            {
                UserId = 1,
                AddressId = 2,
                PizzaIds = new List<int> { 1, 2 },
                Ranks = new List<int> { 3, 4 }
            };
        }
    }
}
