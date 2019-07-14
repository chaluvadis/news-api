using System;
using System.Collections.Generic;
namespace DeviceWebApi.Services
{
    public class MobileService<MobileNews> : IService<MobileNews> where MobileNews : class
    {
        public List<MobileNews> GetAllNews(IDataService<MobileNews> _dataService)
        {
            return _dataService.Collection(20);
        }

        public MobileNews GetNews(Guid guid)
        {
            throw new NotImplementedException();
        }
    }
}