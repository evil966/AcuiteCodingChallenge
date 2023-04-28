using AcuiteCodingChallenge.Entities;
using AcuiteCodingChallenge.Repository.Context;
using System.Web.Http;
using Unity;
using Unity.WebApi;

namespace AcuiteCodingChallenge.Api
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            container.RegisterType<IRepository<Book>, BookRepository>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}