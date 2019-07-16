using Wangkanai.Detection;
using DeviceWebApi.Services;
using DeviceWebApi.Models;

namespace DeviceWebApi.Utilities
{
    public static class Utility
    {
        public static (dynamic, dynamic) GetService(IDeviceResolver deviceResolver)
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
    }
}