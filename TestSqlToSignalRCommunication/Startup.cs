using Microsoft.Owin;
using Owin;
using System;
using System.Threading.Tasks;

[assembly: OwinStartup(typeof(TestSqlToSignalRCommunication.Startup))]

namespace TestSqlToSignalRCommunication
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=316888  
            app.MapSignalR();
        }
    }
}
