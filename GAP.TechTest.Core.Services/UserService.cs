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
    public interface IUserService : IService<User>
    {        
        IList<User> GetAll();
        void Create(User insurancePolicy);       

    }

    public class UserService : Service<User>, IUserService
    {

        private readonly IRepositoryAsync<User> _repository;
        private readonly IUnitOfWorkAsync _unitOfWorkAsync;

        public UserService(IRepositoryAsync<User> repository, IUnitOfWorkAsync unitOfWorkAsync) : base(repository)
        {
            _repository = repository;
            _unitOfWorkAsync = unitOfWorkAsync;
        }
        public void Create(User user) 
        {
                user.Id = Guid.NewGuid();
                _unitOfWorkAsync.Repository<User>().Insert(user);
                _unitOfWorkAsync.SaveChanges();
            
        }

       
        public IList<User> GetAll()
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
