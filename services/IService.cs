using System;
using System.Collections.Generic;
namespace DeviceWebApi.Services
{
    public interface IService<T> where T : class
    {
        List<T> GetAllNews(IDataService<T> dataService);
        T GetNews(Guid guid);
    }
}