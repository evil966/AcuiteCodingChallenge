using AcuiteCodingChallenge.Core.Entities;
using AcuiteCodingChallenge.Infrastructure.Repository;
using AcuiteCodingChallenge.Infrastructure.Repository.Books;
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