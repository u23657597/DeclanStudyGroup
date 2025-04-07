using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

// This is where controllers and actions are managed.

namespace S1L04
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {   
            //Leave alone most of the time.
            //If you want to add additional route then you can add it here.
            //For example Web API additional mapping is provided.
            //Routes is completed in order.

            //Route Handler --
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //If the first route is the WebAPI route then 
            //name: "WebAPI",
            //url: :api/{controller}/{action}/{id}",
            //defaults: new {controller = "ControlName", action = "ActionName", id = urlParameter.Options
            //Then the API route will be executed first.
            //For now, we leave this alone in INF272 - ASP MVC.


            routes.MapRoute(
                name: "Default",
                //This is the default route.
                //After LocalHost: Port look for action and the ID.
                
                url: "{controller}/{action}/{id}",

                //The default is "Home" and the Action is "Index" action and the ID is the optional URL parameter.
                //Do not spec action or controller it will execute default.

                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
