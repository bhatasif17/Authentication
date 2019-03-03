using Autofac;
using Autofac.Integration.Wcf;
using System;
using Service.Data;
using Service.Services.Authentication;

namespace Service
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<AccountWebService>();
            builder.RegisterType<AppDbContext>();
            builder.RegisterGeneric(typeof(EfRepository<>)).As(typeof(IRepository<>)).InstancePerLifetimeScope();
            builder.RegisterType(typeof(StudentRepository)).As(typeof(IStudentRepository)).InstancePerLifetimeScope();
            builder.RegisterType<ApplicationUserStore>().InstancePerLifetimeScope();
            builder.RegisterType<ApplicationUserManager>().InstancePerLifetimeScope();


            var container = builder.Build();
            AutofacHostFactory.Container = container;
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {
          var error =  Server.GetLastError();
            //Log this error
        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}