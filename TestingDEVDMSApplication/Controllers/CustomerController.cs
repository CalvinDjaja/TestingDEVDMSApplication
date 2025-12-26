using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;
using TestingDEVDMSApplication.Models;

namespace TestingDEVDMSApplication.Controllers
{
    [Route(nameof(ViewRoutes.Customer))]
    public class CustomerController : Controller
    {
        public CustomerController()
        {

        }

        [HttpGet("Index")]
        public IActionResult Index()
        {
            return View(ViewRoutes.Customer("Index"));
        }

        [HttpGet("Create")]
        public IActionResult Create()
        {
            return View(ViewRoutes.Customer("Create"));
        }

        [HttpGet("GetQuery")]
        public object GetQuery(DataSourceLoadOptions loadOptions)
        {
            //var data = _customerManagementService.GetCustomerBranchVTQueryable();
            var data = new List<CustomerVT>();
            return DataSourceLoader.Load(data, loadOptions);
        }
    }
}
