using Swagger.Net.Application;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApiRest
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            var enableSwagger = bool.Parse(ConfigurationManager.AppSettings["EnableSwagger"]);
            if (enableSwagger)
            {
                routes.MapHttpRoute(
                    name: "swagger_root",
                    routeTemplate: "",
                    defaults: null,
                    constraints: null,
                    handler: new RedirectHandler((message => GetRequestUri(message.RequestUri)), "swagger/ui/index"));

            }
            else
            {
                routes.MapRoute(
                    name: "Default",
                    url: "{controller}/{action}/{id}",
                    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
                );
            }
        }

        public static string GetRequestUri(Uri uri)
        {
            if (uri.Port.Equals(8083))
            {
                var uriBuilder = new UriBuilder(uri);
                uriBuilder.Port = 80;
                uri = uriBuilder.Uri;
            }

            if (uri.Port.Equals(4433))
            {
                var uriBuilder = new UriBuilder(uri);
                uriBuilder.Port = 443;
                uri = uriBuilder.Uri;
            }

            return uri.ToString().TrimEnd('/');
        }
    }
}
