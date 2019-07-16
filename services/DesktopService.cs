using System;
using System.Linq;
using System.Collections.Generic;
using DeviceWebApi.Models;
// https://dejanstojanovic.net/aspnet/2018/december/registering-multiple-implementations-of-the-same-interface-in-aspnet-core/
namespace DeviceWebApi.Services
{
    public class DesktopService<DesktopNews> : IService<DesktopNews> where DesktopNews : class
    {
        private List<DesktopNews> _desktopNews = new List<DesktopNews>();
        public List<DesktopNews> GetAllNews(IDataService<DesktopNews> _dataService)
        {
            _desktopNews = _dataService.Collection(20);
            return _desktopNews;
        }

        public DesktopNews GetNews(Guid id) => throw new NotImplementedException();
    }
}