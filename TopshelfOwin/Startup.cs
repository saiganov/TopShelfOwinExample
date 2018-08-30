using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using Owin;

namespace TopshelfOwin
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var config = ConfigureApi();
            app.UseWebApi(config);
        }

        private HttpConfiguration ConfigureApi()
        {
            var config = new HttpConfiguration();
            config.Routes.MapHttpRoute(
                "DefaultApi",
                "api/{controller}/{id}",
                new { id = RouteParameter.Optional });
            return config;
        }
    }
}
