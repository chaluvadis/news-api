using System;
using System.Collections.Generic;
namespace DeviceWebApi.Services
{
    public class TabletService<TabletNews> : IService<TabletNews> where TabletNews : class
    {
        public List<TabletNews> GetAllNews(IDataService<TabletNews> _dataService)
        {
            return _dataService.Collection(20);
        }

        public TabletNews GetNews(Guid guid) => throw new NotImplementedException();
    }
}