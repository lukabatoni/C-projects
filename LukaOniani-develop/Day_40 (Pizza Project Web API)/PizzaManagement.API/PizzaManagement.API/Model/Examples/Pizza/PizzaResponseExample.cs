using PizzaManagement.Application.Entities.PizzaFolder;
using Swashbuckle.AspNetCore.Filters;

namespace PizzaManagement.API.Model.Examples.Pizza
{
    public class PizzaResponseExample : IExamplesProvider<PizzaResponseModel>
    {
        public PizzaResponseModel GetExamples()
        {
            return new PizzaResponseModel()
            {
                Id = 2,
                Name = "Proschutto",
                Price = 17,
                Description = "Pizza with bacon and cheese.",
                CaloryCount = 1200
            };
        }
    }
}
