using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace MarubeniCreditWeb
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            MvcHandler.DisableMvcResponseHeader = true; //Remove X-AspNetMVC-Version Header
        }

        protected void Application_PreSendRequestHeaders()
        {
            if (HttpContext.Current != null)
            {

                Response.Headers.Remove("Server");           //Remove Server Header   
                Response.Headers.Remove("X-AspNet-Version"); //Remove X-AspNet-Version Header
            }
        }

        protected void Application_PostAuthenticateRequest(Object sender, EventArgs e)
        {
            //HttpCookie authCookie = Request.Cookies[FormsAuthentication.FormsCookieName];

            if (Request.Cookies.Count > 0)
            {
                foreach (string s in Request.Cookies.AllKeys)
                {

                    Request.Cookies[s].Secure = true;
                    Request.Cookies[s].HttpOnly = true;
                    Response.AppendCookie(Request.Cookies[s]);

                }
            }

        }

        protected void Application_Error(object sender, EventArgs e)
        {
            Exception exception = Server.GetLastError();
            Response.Clear();

            HttpException httpException = exception as HttpException;

            int error = httpException != null ? httpException.GetHttpCode() : 0;

            Server.ClearError();
            Response.Redirect(String.Format("~/Home/Error", error, exception.Message));
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            // Código que se ejecuta cuando se inicia una nueva sesión

        }
    }
}
