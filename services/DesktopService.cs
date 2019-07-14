using System;
using System.Collections.Generic;
using DeviceWebApi.Models;
// https://dejanstojanovic.net/aspnet/2018/december/registering-multiple-implementations-of-the-same-interface-in-aspnet-core/
namespace DeviceWebApi.Services
{
    public class DesktopService<DesktopNews> : IService<DesktopNews> where DesktopNews : class
    {
        public List<DesktopNews> GetAllNews(IDataService<DesktopNews> _dataService)
        {
            return _dataService.Collection(20);
        }

        public DesktopNews GetNews(Guid guid)
        {
            throw new NotImplementedException();
        }
    }
}