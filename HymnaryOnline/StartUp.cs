using Microsoft.Owin;
using Microsoft.AspNet.SignalR;
using Owin;
using HymnaryOnline;

[assembly: OwinStartup(typeof(HymnaryOnline.Startup))]
namespace HymnaryOnline
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}