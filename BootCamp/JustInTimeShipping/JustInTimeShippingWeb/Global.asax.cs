using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace JustInTimeShippingWeb
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapRoute(
            //    "Default", // Route name
            //    "{controller}/{action}/{id}", // URL with parameters
            //    new { controller = "Home", action = "Index", id = UrlParameter.Optional } // Parameter defaults
            //);


            routes.MapRoute(
                "DefaultedPackageAndDelivery", // Route name
                "P{packageType}/D{deliveryType}", // URL with parameters
                new { controller = "Kiosk", action = "Main", packageType = "B", deliveryType = "R" } // Parameter defaults
            );

            routes.MapRoute(
                "DefaultedDeliveryAndPackage", // Route name
                "D{deliveryType}/P{packageType}", // URL with parameters
                new { controller = "Kiosk", action = "Main", packageType = "B", deliveryType = "R" } // Parameter defaults
            );

            routes.MapRoute(
                "DefaultedPackage", // Route name
                "P{packageType}", // URL with parameters
                new { controller = "Kiosk", action = "Main", packageType = "B", deliveryType = "R" } // Parameter defaults
            );

            routes.MapRoute(
                "DefaultedDelivery", // Route name
                "D{deliveryType}", // URL with parameters
                new { controller = "Kiosk", action = "Main", packageType = "B", deliveryType = "R" } // Parameter defaults
            );

            routes.MapRoute(
                "ActionWithDefaultedPackageAndDelivery", // Route name
                "{action}/P{packageType}/D{deliveryType}", // URL with parameters
                new { controller = "Kiosk", action = "Main", packageType = "B", deliveryType = "R" } // Parameter defaults
            );

            routes.MapRoute(
                "ControllerAndActionWithDefaultedPackageAndDelivery", // Route name
                "{controller}/{action}/P{packageType}/D{deliveryType}", // URL with parameters
                new { controller = "Kiosk", action = "Main", packageType = "B", deliveryType = "R" } // Parameter defaults
            );

            routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}/", // URL with parameters
                new { controller = "Kiosk", action = "Default", packageType = "B", deliveryType = "R" } // Parameter defaults
            );
            

        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);
        }
    }
}