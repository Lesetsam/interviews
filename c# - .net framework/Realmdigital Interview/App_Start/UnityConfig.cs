using Microsoft.Practices.Unity;
using Realmdigital_Interview.Repositories;
using System.Web.Http;
using Unity.WebApi;

namespace Realmdigital_Interview
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IProductRepository, ApiCaller>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}