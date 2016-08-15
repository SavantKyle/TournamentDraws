using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Web.Compilation;
using Autofac;
using Autofac.Integration.WebApi;
using Business;
using Business.Contracts;
using DataProvider;
using DataProvider.Contracts;

namespace IoC
{
    public class DependencyInjection
    {
        public static ContainerBuilder BuildIocContainer(Assembly assembly)
        {
            var builder = new ContainerBuilder();

            //Register the Web API Controllers 
            builder.RegisterApiControllers(assembly).PropertiesAutowired();
            var assemblies = BuildManager.GetReferencedAssemblies().Cast<Assembly>().ToArray();

            //Register Services
            builder.RegisterAssemblyTypes(assemblies).Where(x => x.Name.EndsWith("Service")).AsImplementedInterfaces();
            //builder.RegisterAssemblyTypes(assemblies).Where(x => x.Name.EndsWith("Facade")).AsImplementedInterfaces();

            builder.RegisterType<Facade>().As<IFacade>();
            builder.RegisterType<Database>().As<IDatabase>();
            builder.RegisterType<Session>().As<ISession>();
            builder.Register(
                x => new DapperContext(ConfigurationManager.ConnectionStrings["TournamentDraws"].ConnectionString)).InstancePerDependency()
                .As<IDapperContext>();

            return builder;
        }
    }
}