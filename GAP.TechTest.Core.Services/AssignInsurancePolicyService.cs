using GAP.TechTest.Core.Entities.Common;
using GAP.TechTest.Core.Entities.InsurancePolicies;
using GAP.TechTest.Core.Entities.InsurancePolicies.Enum;
using GAP.TechTest.Core.Entities.Users;
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
    public interface IAssignInsurancePolicyService : IService<UserPolicy>
    {        
        void Assign(UserPolicy userPolicy);
        void Cancel(Guid id);
        IList<UserPolicy> GetAll();
    }

    public class AssignInsurancePolicyService : Service<UserPolicy>, IAssignInsurancePolicyService
    {

        private readonly IRepositoryAsync<UserPolicy> _repository;
        private readonly IUnitOfWorkAsync _unitOfWorkAsync;

        public AssignInsurancePolicyService(IRepositoryAsync<UserPolicy> repository, IUnitOfWorkAsync unitOfWorkAsync) : base(repository)
        {
            _repository = repository;
            _unitOfWorkAsync = unitOfWorkAsync;
        }

        public void Assign(UserPolicy userPolicy)
        {
            try
            {
                userPolicy.Id = Guid.NewGuid();
                _unitOfWorkAsync.Repository<UserPolicy>().Insert(userPolicy);
                _unitOfWorkAsync.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Cancel(Guid id)
        {
            try
            {
                var userPolicy = _repository.Queryable().FirstOrDefault(x => x.Id == id);
                _unitOfWorkAsync.Repository<UserPolicy>().Delete(userPolicy);
                _unitOfWorkAsync.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public IList<UserPolicy> GetAll()
        {
            try
            {
                return _repository.Queryable().ToList();
            }
            catch (Exception e)
            {
                //log
                throw e;
            }

        }



    }
}
