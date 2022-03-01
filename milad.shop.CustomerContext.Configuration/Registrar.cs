using Castle.MicroKernel.Registration;
using Castle.Windsor;
using milad.Framework.Application;
using milad.Framework.Core.Security;
using milad.Framework.DependencyInjection;
using milad.Framework.Domain;
using milad.Framework.Facade;
using milad.Framework.Security;
using milad.shop.CustomerContext.Application.Customers;
using milad.shop.CustomerContext.Domain.Services.Customers;
using milad.shop.CustomerContext.Facade;

namespace milad.shop.CustomerContext.Configuration
{
    public class Registrar : IRegistrar
    {
        public void Register(WindsorContainer container)
        {
            container.Register(
                Component.For<IHashProvider>()
                         .ImplementedBy<HashProvider>()
                         .LifestyleSingleton());

            container.Register(
                Classes.FromAssemblyContaining<SignupCommandHandler>()
                       .BasedOn(typeof(ICommandHandler<>))
                       .WithServiceAllInterfaces()
                       .LifestyleTransient());

            container.Register(
                Classes.FromAssemblyContaining<CustomerCommandFacade>()
                       .BasedOn(typeof(BaseCommandFacade))
                       .WithServiceAllInterfaces()
                       .LifestyleTransient());

            container.Register(
                Classes.FromAssemblyContaining<EmailDuplicationChecker>()
                       .BasedOn<IDomainService>()
                       .WithServiceAllInterfaces()
                       .LifestyleTransient());
                       
        }
    }
}
