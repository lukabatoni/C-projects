using CompanyManagement.Application;
using CompanyManagement.Application.Exceptions;
using Microsoft.AspNetCore.Mvc;

namespace CompanyManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        //localhost:7747/api/Company

        private readonly ICompanyService _companyService;

        public CompanyController(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        #region Endpoints

        [HttpGet]
        public List<string> GetCompanies()
        {
            return _companyService.GetCompanies();
        }


        [HttpGet("{id}")]
        public string GetCompanyByName(string id)
        { 
            var companies = _companyService.GetCompanyByName(id);
            return companies;
        }


        [HttpDelete("{id}")]
        public bool Delete(string id)
        {
            return _companyService.Delete(id);
        }

        #endregion
    }
}
