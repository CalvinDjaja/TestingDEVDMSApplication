using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;
using TestingDEVDMSApplication.Models;
using TestingDEVDMSApplication.Services.Interface;

namespace TestingDEVDMSApplication.Controllers
{
    [Route(nameof(ViewRoutes.ScoreGroup))]
    public class ScoreGroupController : Controller
    {
        private readonly IScoreGroupService scoreGroupService;
        public ScoreGroupController(IScoreGroupService scoreGroupService)
        {
            this.scoreGroupService = scoreGroupService;
        }

        [HttpGet("Index")]
        public IActionResult Index()
        {
            return View(ViewRoutes.ScoreGroup("Index"));
        }

        [HttpGet("Create")]
        public IActionResult Create()
        {
            return View(ViewRoutes.ScoreGroup("Create"));
        }

        [HttpGet, Route("Update/{ID}")]
        public IActionResult Update(int ID)
        {
            //var result = scoreGroupService.GetCustomerByID(ID);
            //if (result != null)
            //{
            //    return View(ViewRoutes.Customer("Update"), result);
            //}
            return View(ViewRoutes.Customer("Index"));
        }

        [HttpGet("GetAllScoreGroup")]
        public object GetAllScoreGroup(DataSourceLoadOptions loadOptions)
        {
            var data = scoreGroupService.GetAllScoreGroup();
            return DataSourceLoader.Load(data, loadOptions);
        }

        [HttpGet("GetAllScoreGroupItem")]
        public object GetAllScoreGroupItem(DataSourceLoadOptions loadOptions)
        {
            var data = scoreGroupService.GetAllScoreGroupItem();
            return DataSourceLoader.Load(data, loadOptions);
        }

        [HttpGet("GetScoreGroupItemByScoreGroup")]
        public object GetScoreGroupItemByScoreGroup(DataSourceLoadOptions loadOptions, int ScoreGroup)
        {
            var data = scoreGroupService.GetAllScoreGroupItem().Where(a => a.GroupID == ScoreGroup).AsQueryable();
            return DataSourceLoader.Load(data, loadOptions);
        }

        [HttpGet("GetAllScoreItem")]
        public object GetAllScoreItem(DataSourceLoadOptions loadOptions)
        {
            var data = scoreGroupService.GetAllScoreItem();
            return DataSourceLoader.Load(data, loadOptions);
        }

        [HttpPost("CreateScoreItem"), ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateScoreItem([FromBody] CreateOrUpdateCustomerRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Parameter required");
            }

            //var result = await customerService.InsertCustomer(request);
            //if (result == "Success")
            //{
            //    return Ok(result);
            //}

            return BadRequest();

        }

        [HttpPost("UpdateScoreItem"), ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateScoreItem([FromBody] CreateOrUpdateCustomerRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Parameter required");
            }

            //var result = await customerService.UpdateCustomer(request);
            //if (result == "Success")
            //{
            //    return Ok(result);
            //}

            return BadRequest();

        }

    }

}
