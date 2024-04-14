using PizzaManagement.API.Model.Requests;
using Swashbuckle.AspNetCore.Filters;

namespace PizzaManagement.API.Model.Examples.Pizza
{
    public class PizzaCreateExample : IExamplesProvider<PizzaCreateModel>
    {
        public PizzaCreateModel GetExamples()
        {
            return new PizzaCreateModel()
            {
                Name = "Proschutto",
                Price = 17,
                Description = "Pizza with bacon and cheese.",
                CaloryCount = 1200
            };
        }
    }
}
