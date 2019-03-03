using AuthenticationProject.Services;
using Autofac;
using Autofac.Integration.Mvc;
using Client.Services;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Client
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            var builder = new ContainerBuilder();

            builder.RegisterModule(new AutofacWebTypesModule());

            // Register your MVC controllers. (MvcApplication is the name of
            // the class in Global.asax.)
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            builder.RegisterType<IdentityAuthService>()
                .As<IAuthService>()
                .As<IIdentityAuthService>();

            builder.RegisterType<StudentService>()
               .As<IStudentService>();

            // You can uncomment here for Form Authentication, but make sure builder.RegisterType<IdentityAuthService>()... line is disabled
            //builder.RegisterType<FormAuthService>()
            //    .As<IAuthService>();                

            // Set the dependency resolver to be Autofac.
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

            Startup.Container = container;
        }
    }
}
