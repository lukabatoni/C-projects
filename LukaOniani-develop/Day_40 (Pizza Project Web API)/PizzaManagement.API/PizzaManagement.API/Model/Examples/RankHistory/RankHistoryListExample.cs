using PizzaManagement.Application.Entities.PizzaFolder;
using PizzaManagement.Application.Entities.RankHistoryFolder;
using Swashbuckle.AspNetCore.Filters;

namespace PizzaManagement.API.Model.Examples.RankHistory
{
    public class RankHistoryListExample : IExamplesProvider<List<RankHistoryResponseModel>>
    {
        public List<RankHistoryResponseModel> GetExamples()
        {
            return new List<RankHistoryResponseModel>
            {
                new RankHistoryResponseModel()
                {
                    UserId = 2, 
                    PizzaId = 2, 
                    Rank = 7
                }
            };
        }
    }
}
