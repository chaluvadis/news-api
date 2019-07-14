using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Wangkanai.Detection;
using DeviceWebApi.Services;
using DeviceWebApi.Models;

namespace DeviceWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IDevice _device;
        private readonly dynamic _dataService;

        private readonly dynamic _service;
        private (dynamic, dynamic) GetService(IDeviceResolver deviceResolver)
        {
            if (deviceResolver.Device.Type == DeviceType.Mobile)
            {
                return (new MobileService<MobileNews>(), new DataService<MobileNews>());
            }
            else if (deviceResolver.Device.Type == DeviceType.Tablet)
            {
                return (new TabletService<TabletNews>(), new DataService<TabletNews>());
            }
            else
            {
                return (new DesktopService<DesktopNews>(), new DataService<DesktopNews>());
            }
        }

        public ValuesController(IDeviceResolver deviceResolver)
        {
            // tuple order resolves the dependeny
            (this._service, this._dataService) = GetService(deviceResolver);
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<dynamic>> Get()
        {
            return this._service.GetAllNews(this._dataService);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "this.device.Type.ToString();";
        }
    }
}
