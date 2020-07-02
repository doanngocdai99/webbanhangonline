using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace doan_dbsm
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
           
            routes.MapRoute(
                name: "Default",
                url: "product-{id}",
                defaults: new { controller = "Product", action = "Grproduct", id = UrlParameter.Optional }
            );
            routes.MapRoute(
              name: "about",
              url: "about",
              defaults: new { controller = "About", action = "index", id = UrlParameter.Optional }
          );
            routes.MapRoute(
             name: "login",
             url: "login",
             defaults: new { controller = "Login", action = "index", id = UrlParameter.Optional }
         );
            routes.MapRoute(
                 name: "product",
                 url: "product",
                 defaults: new { controller = "Product", action = "Index", id = UrlParameter.Optional }
         );
            routes.MapRoute(
               name: "Features",
               url: "Features",
               defaults: new { controller = "CART", action = "Cart", id = UrlParameter.Optional }
       );
            routes.MapRoute(
             name: "blog",
             url: "blog",
             defaults: new { controller = "Blog", action = "Index", id = UrlParameter.Optional }
 );

            routes.MapRoute(
              name: "contact",
              url: "contact",
              defaults: new { controller = "Contact", action = "Index", id = UrlParameter.Optional }
 );

            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
             routes.MapRoute(
              name: "Product category",
              url: "{controller}/{action}/{id}",
              defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
          );

            
        }
    }
}
