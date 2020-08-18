using AutoMapper;
using GAP.TechTest.Core.Entities.InsurancePolicies;
using GAP.TechTest.Core.Entities.Users;
using GAP.TechTest.Core.Services;
using GAP.TechTest.EntityFramework.UnitOfWork;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiRest.Controllers
{
    [AllowAnonymous]
    public class UserPolicyController : ApiController
    {

        private readonly IAssignInsurancePolicyService _userPolicyService;        
        //private readonly IObjectMapper ObjectMapper;


        public UserPolicyController(IAssignInsurancePolicyService userPolicyService)
        {
            _userPolicyService = userPolicyService;            
        }

        // GET api/values
        public IList<UserPolicyDto> Get()
        {
            var insurancePolicies = _userPolicyService.GetAll();
            var result = insurancePolicies.Select(x => new UserPolicyDto
            {
               UserId = x.UserId,
               InsurancePolicyId = x.InsurancePolicyId
            }).ToList();
            return result;
        }



        // POST api/values
        public bool Post([FromBody] UserPolicyDto userPolicy)
        {
            try
            {
                var data = new UserPolicy
                {
                   InsurancePolicyId = userPolicy.InsurancePolicyId,
                   UserId = userPolicy.UserId
                };

                _userPolicyService.Assign(data);                
                return true;
            }
            catch (Exception e){
                return false;
            }

        }

        // DELETE api/values/5
        public bool Delete(Guid id)
        {
            try
            {
                _userPolicyService.Cancel(id);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

    }
}
