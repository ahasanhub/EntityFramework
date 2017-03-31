using System;
using System.Threading.Tasks;
using System.Web.Http;
using Microsoft.Owin;
using Owin;
using Swashbuckle.Application;

[assembly: OwinStartup(typeof(CI.EF.WebApi.Startup))]

namespace CI.EF.WebApi
{
    /// <summary>
    /// This is start up class for web api
    /// </summary>
    public class Startup
    {
        //This code configures Web Api. 
        //The startup class is specified as a type paramenter in the WebApp.Start method
        public void Configuration(IAppBuilder app)
        {
            var config=new HttpConfiguration();
            config.EnableSwagger(c=>c.SingleApiVersion("v1", "A title for your API")).EnableSwaggerUi();
            WebApiConfig.Register(config);
            app.UseWebApi(config);
        }
    }
}
