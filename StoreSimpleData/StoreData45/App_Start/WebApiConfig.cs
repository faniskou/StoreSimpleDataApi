using System;
using System.Web.Http;
using SimpleInjector;
using SimpleInjector.Integration.WebApi;
using StoreSimpleData.Interfaces;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

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
            Func<IDbConnection> apiConnection = () =>
            {
                var connection = new SqlConnection(dbcon);
                connection.Open();
                return connection;
            };
            container.Register(() => apiConnection, Lifestyle.Singleton);
            container.Register<IStoreSimpleData>(() => new StoreSimpleData.Implementation.StoreSimpleData(container.GetInstance<Func<IDbConnection>>()));

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
                , defaults: new { controller="test", action = "hello"  }
            );
        }
    }
}
