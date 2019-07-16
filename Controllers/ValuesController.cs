using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Wangkanai.Detection;
using DeviceWebApi.Utilities;

namespace DeviceWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IDevice _device;
        private readonly dynamic _dataService;
        private readonly dynamic _service;
        public ValuesController(IDeviceResolver deviceResolver) => (this._service, this._dataService) = Utility.GetService(deviceResolver);

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<dynamic>> Get() => this._service.GetAllNews(this._dataService);
    }
}
