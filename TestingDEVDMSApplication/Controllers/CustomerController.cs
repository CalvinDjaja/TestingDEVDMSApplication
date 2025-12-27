using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;
using TestingDEVDMSApplication.Services.Interface;

namespace TestingDEVDMSApplication.Controllers
{
    [Route(nameof(ViewRoutes.Customer))]
    public class CustomerController : Controller
    {
        private readonly ICustomerService customerService;
        public CustomerController(ICustomerService customerService)
        {
            this.customerService = customerService;
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
            var data = customerService.GetAllCustomer();
            return DataSourceLoader.Load(data, loadOptions);
        }

        [HttpGet("GetEducation")]
        public object GetEducation(DataSourceLoadOptions loadOptions)
        {
            var data = customerService.GetAllEducation();
            return DataSourceLoader.Load(data, loadOptions);
        }

        [HttpGet("GetKepemilikan")]
        public object GetKepemilikan(DataSourceLoadOptions loadOptions)
        {
            var data = customerService.GetAllKepemilikan();
            return DataSourceLoader.Load(data, loadOptions);
        }

        [HttpGet("GetKategoriPerushaan")]
        public object GetKategoriPerushaan(DataSourceLoadOptions loadOptions)
        {
            var data = customerService.GetAllKategoriPerushaan();
            return DataSourceLoader.Load(data, loadOptions);
        }

        [HttpGet("GetJabatan")]
        public object GetJabatan(DataSourceLoadOptions loadOptions)
        {
            var data = customerService.GetAllJabatan();
            return DataSourceLoader.Load(data, loadOptions);
        }

        [HttpGet("GetRecordPembayaranAngsuran")]
        public object GetRecordPembayaranAngsuran(DataSourceLoadOptions loadOptions)
        {
            var data = customerService.GetAllRecordPaymentTrack();
            return DataSourceLoader.Load(data, loadOptions);
        }

        [HttpGet("GetTrackDataSLIK")]
        public object GetTrackDataSLIK(DataSourceLoadOptions loadOptions)
        {
            var data = customerService.GetAllTrackDataSLIK();
            return DataSourceLoader.Load(data, loadOptions);
        }

        [HttpGet("GetPemilikanKartuKredit")]
        public object GetPemilikanKartuKredit(DataSourceLoadOptions loadOptions)
        {
            var data = customerService.GetAllPemilikanKartuKredit();
            return DataSourceLoader.Load(data, loadOptions);
        }

        [HttpGet("GetTujuanDariPembiayaan")]
        public object GetTujuanDariPembiayaan(DataSourceLoadOptions loadOptions)
        {
            var data = customerService.GetAllTujuanDariPembiayaan();
            return DataSourceLoader.Load(data, loadOptions);
        }
    }
}
