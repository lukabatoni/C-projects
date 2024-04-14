using PizzaManagement.Application.Entities.PizzaFolder;
using Swashbuckle.AspNetCore.Filters;

namespace PizzaManagement.API.Model.Examples.Pizza
{
    public class PizzaListResponseExample : IExamplesProvider<List<PizzaResponseModel>>
    {
        public List<PizzaResponseModel> GetExamples()
        {
            return new List<PizzaResponseModel>
            {
                new PizzaResponseModel()
                {
                    Id = 2,
                    Name = "Proschutto",
                    Price = 17,
                    Description = "Pizza with bacon and cheese.",
                    CaloryCount = 1200
                }
            };
        }
    }
}
