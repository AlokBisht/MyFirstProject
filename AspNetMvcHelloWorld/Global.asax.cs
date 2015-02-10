using System;
using System.Web;
using System.Web.Routing;

namespace AspNetMvcHelloWorld
{
    public class Global : HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
