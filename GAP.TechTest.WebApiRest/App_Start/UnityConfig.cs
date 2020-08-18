
using GAP.TechTest.Core.Services.IoC;
using GAP.TechTest.EntityFramework.DataContext;
using GAP.TechTest.EntityFramework.UnitOfWork;
using System;
using Unity;
using Unity.AspNet.Mvc;

namespace WebApiRest
{
    public class UnityConfig
    {
        #region Unity Container
        private static Lazy<IUnityContainer> container = new Lazy<IUnityContainer>(() =>
        {
            var container = new UnityContainer();
            RegisterTypes(container);
            return container;
        });

        /// <summary>
        /// Gets the configured Unity container.
        /// </summary>
        public static IUnityContainer GetConfiguredContainer()
        {
            return container.Value;
        }
        #endregion

        public static void RegisterTypes(IUnityContainer container)
        {
            var applicationName = "GAP.TechTest.WebApiRest";


            DependencyResolver.Resolve(container, applicationName);
            container
                .RegisterType<IDataContextAsync, InsurancePolicyContext>(new PerRequestLifetimeManager())
                .RegisterType<IUnitOfWorkAsync, UnitOfWork>(new PerRequestLifetimeManager());

        }


    }
}