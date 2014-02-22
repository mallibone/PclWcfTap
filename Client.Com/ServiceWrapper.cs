using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Client.Com.ServiceReference;

namespace Client.Com
{

    public interface IServiceWrapper
    {
        Task<string> LoginAsync(string username, string password);
    }

    public class ServiceWrapper:IServiceWrapper
    {
        public Task<string> LoginAsync(string username, string password)
        {
	    // Note: the endpoint address should not be hardwired at this point!
            IService service = new ServiceClient(new ServiceClient.EndpointConfiguration(), new EndpointAddress("http://localhost:51787/SimpleService.svc"));

            return new TaskFactory().FromAsync<string, string, string>(service.BeginLogin, service.EndLogin, username, password, new object());
        }
    }
}
