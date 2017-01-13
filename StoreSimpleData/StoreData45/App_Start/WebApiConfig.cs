using System.Web.Http;
using SimpleInjector;
using SimpleInjector.Integration.WebApi;
using StoreSimpleData.Interfaces;
using StoreSimpleData.Implementation;
using System.Configuration;

namespace StoreData45
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new WebApiRequestLifestyle();

            // Register your types, for instance using the scoped lifestyle:
            string dbcon = ConfigurationManager.AppSettings["Dbcon"];
            container.Register<IStoreSimpleData>(() => new StoreSimpleData.Implementation.StoreSimpleData(dbcon));

            // This is an extension method from the integration package.
            container.RegisterWebApiControllers(GlobalConfiguration.Configuration);

            container.Verify();

            GlobalConfiguration.Configuration.DependencyResolver =
                new SimpleInjectorWebApiDependencyResolver(container);

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "{controller}/{action}"
                , defaults: new { action = "hello" }
            );
        }
    }
}
