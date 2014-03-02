using System.ServiceModel;
using System.Threading.Tasks;
using Client.Com.SimpleServiceReference;

namespace Client.Com
{

    public interface IServiceWrapper
    {
        Task<bool> LoginAsync(string username, string password);
    }

    public class ServiceWrapper:IServiceWrapper
    {
        public Task<bool> LoginAsync(string username, string password)
        {
	    // Note: the endpoint address should not be hardwired at this point!
            IService service = new ServiceClient(new ServiceClient.EndpointConfiguration(), new EndpointAddress("http://localhost:51787/SimpleService.svc"));

            return new TaskFactory().FromAsync<string, string, bool>(service.BeginLogin, service.EndLogin, username, password, new object());
        }
    }
}
