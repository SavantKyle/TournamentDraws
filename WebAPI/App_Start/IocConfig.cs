using System.Reflection;
using System.Web.Http;
using Autofac.Integration.WebApi;
using IoC;

namespace WebAPI.App_Start
{
    public class IocConfig
    {
        public static void RegisterIoc(HttpConfiguration configuration)
        {
            //Create the container builder
            var builder = DependencyInjection.BuildIocContainer(Assembly.GetExecutingAssembly());

            //Set the dependency resolver to be Autofac
            var container = builder.Build();
            configuration.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}