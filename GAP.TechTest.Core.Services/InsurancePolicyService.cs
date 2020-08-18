using GAP.TechTest.Core.Entities.Common;
using GAP.TechTest.Core.Entities.InsurancePolicies;
using GAP.TechTest.Core.Entities.InsurancePolicies.Enum;
using GAP.TechTest.EntityFramework.Repository;
using GAP.TechTest.EntityFramework.Service;
using GAP.TechTest.EntityFramework.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAP.TechTest.Core.Services
{
    public interface IInsurancePolicyService : IService<InsurancePolicy>
    {        
        IList<InsurancePolicy> GetAll();
        void Create(InsurancePolicy insurancePolicy);
        void Renew(InsurancePolicy insurancePolicy);
        void Remove(Guid id);
        InsurancePolicy GetById(Guid id);

    }

    public class InsurancePolicyService : Service<InsurancePolicy>, IInsurancePolicyService
    {

        private readonly IRepositoryAsync<InsurancePolicy> _repository;
        private readonly IUnitOfWorkAsync _unitOfWorkAsync;

        public InsurancePolicyService(IRepositoryAsync<InsurancePolicy> repository, IUnitOfWorkAsync unitOfWorkAsync) : base(repository)
        {
            _repository = repository;
            _unitOfWorkAsync = unitOfWorkAsync;
        }
        public void Create(InsurancePolicy insurancePolicy) 
        {

            if ((insurancePolicy.RiskType == Risk.Alto) && (insurancePolicy.CoverageType?.Percent > 50))
                throw new Exception("Si el riesgo es alto, el porcentaje de cubrimiento no puede exceder del 50%");
            else
            {
                
                insurancePolicy.CoverageType.Id = Guid.NewGuid();
                _unitOfWorkAsync.Repository<Coverage>().Insert(insurancePolicy.CoverageType);
                insurancePolicy.Id = Guid.NewGuid();
                _unitOfWorkAsync.Repository<InsurancePolicy>().Insert(insurancePolicy);
                _unitOfWorkAsync.SaveChanges();
            }
        }

        public void Renew(InsurancePolicy insurancePolicy)
        {

            if ((insurancePolicy.RiskType == Risk.Alto) && (insurancePolicy.CoverageType?.Percent > 50))
                throw new Exception("Si el riesgo es alto, el porcentaje de cubrimiento no puede exceder del 50%");
            else
            {
                
                _unitOfWorkAsync.Repository<Coverage>().Update(insurancePolicy.CoverageType);                
                _unitOfWorkAsync.Repository<InsurancePolicy>().Update(insurancePolicy);
                _unitOfWorkAsync.SaveChanges();
            }
        }

        public void Remove(Guid id)
        {
            try
            {
                var insurancePolicy = _repository.Queryable().Include(x => x.CoverageType).FirstOrDefault(x => x.Id == id);
                _unitOfWorkAsync.Repository<Coverage>().Delete(insurancePolicy.CoverageType);
                _unitOfWorkAsync.Repository<InsurancePolicy>().Delete(insurancePolicy);
                _unitOfWorkAsync.SaveChanges();
            }catch (Exception e)
            {
                throw e;
            }
        }

        public IList<InsurancePolicy> GetAll()
        {
            try
            {
                return _repository.Queryable().Include(x=>x.CoverageType).ToList();
            }
            catch (Exception e)
            {
                //log
                throw e;
            }
            
        }

        public InsurancePolicy GetById(Guid id)
        {
            try
            {
                return _repository.Queryable().Include(x => x.CoverageType).FirstOrDefault(x=>x.Id == id);
            }
            catch (Exception e)
            {
                //log
                throw e;
            }

        }


    }
}
