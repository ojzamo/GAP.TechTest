using GAP.TechTest.Core.Entities.InsurancePolicies;
using GAP.TechTest.Core.Entities.Users;
using GAP.TechTest.EntityFramework.DataContext;
using GAP.TechTest.EntityFramework.Repositories;
using GAP.TechTest.EntityFramework.Repository;
using GAP.TechTest.EntityFramework.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace GAP.TechTest.Core.Services.IoC
{
    public static class DependencyResolver
    {
        public static void Resolve(IUnityContainer container, string applicationName)
        {
            try
            {
                if (container == null)
                    throw new ArgumentNullException("UnityContainer");
                if (string.IsNullOrEmpty(applicationName))
                    throw new ArgumentNullException("ApplicationName");

                container
                    .RegisterType<IDataContextAsync, InsurancePolicyContext>()
                    .RegisterType<IUnitOfWorkAsync, UnitOfWork>()
                    .RegisterType<IRepositoryAsync<InsurancePolicy>, Repository<InsurancePolicy>>()
                    .RegisterType<IRepositoryAsync<Coverage>, Repository<Coverage>>()
                    .RegisterType<IRepositoryAsync<User>, Repository<User>>()

                    .RegisterType<IInsurancePolicyService, InsurancePolicyService>()
                    .RegisterType<IAssignInsurancePolicyService, AssignInsurancePolicyService>()                     
                    .RegisterType<IUserService, UserService>();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
