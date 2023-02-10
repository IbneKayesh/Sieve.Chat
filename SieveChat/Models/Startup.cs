using Microsoft.Owin;
using Owin;


[assembly: OwinStartup(typeof(SieveChat.Models.Startup))]
namespace SieveChat.Models
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}