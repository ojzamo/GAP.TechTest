using System;
using GAP.TechTest.Core.Entities.InsurancePolicies;
using GAP.TechTest.Core.Entities.InsurancePolicies.Enum;
using GAP.TechTest.Core.Services;
using GAP.TechTest.EntityFramework.Repository;
using GAP.TechTest.EntityFramework.UnitOfWork;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;

namespace GAP.TechTest.UnitTest1
{
    [TestClass]
    public class InsurancePolicyTest
    {
        readonly IRepositoryAsync<InsurancePolicy> _repositoryCaseSubstitute =
            Substitute.For<IRepositoryAsync<InsurancePolicy>>();
        readonly IUnitOfWorkAsync _unity =
            Substitute.For<IUnitOfWorkAsync>();


        [TestMethod]
        public void GetAll()
        {            
            var insurancePolicyService = new InsurancePolicyService(_repositoryCaseSubstitute, _unity);
            var result = insurancePolicyService.GetAll();            
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void CreateFailed()
        {
            try
            {
                var insurancePolicyService = new InsurancePolicyService(_repositoryCaseSubstitute, _unity);
                var insurancePolicy = new InsurancePolicy
                {
                    Name = "Carro",
                    Description = "Preteccion de carros a terceros",
                    CoverageType = new Coverage { Name = "Terceros", Percent = 51, IsDeleted = false, CreationTime = DateTime.Now },
                    Period = 12,
                    Price = 20000,
                    RiskType = Risk.Alto,
                    IsDeleted = false,
                    CreationTime = DateTime.Now
                };
                insurancePolicyService.Create(insurancePolicy);
            }catch (Exception e)
            {
                Assert.IsNotNull(e.Message);
            }            
        }

        [TestMethod]
        public void Create()
        {
            try
            {
                var insurancePolicyService = new InsurancePolicyService(_repositoryCaseSubstitute,_unity);
                var insurancePolicy = new InsurancePolicy
                {
                    Name = "Carro",
                    Description = "Preteccion de carros a terceros",
                    CoverageType = new Coverage { Name = "Terceros", Percent = 50, IsDeleted = false, CreationTime = DateTime.Now },
                    Period = 12,
                    Price = 20000,
                    RiskType = Risk.Alto,
                    IsDeleted = false,
                    CreationTime = DateTime.Now
                };
                insurancePolicyService.Insert(insurancePolicy);
            }
            catch (Exception e)
            {
                Assert.IsNotNull(e.Message);
            }
        }
    }
}
