using AutoMapper;
using GAP.TechTest.Core.Entities.InsurancePolicies;
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
    public class InsurancePolicyController : ApiController
    {

        private readonly IInsurancePolicyService _insurancePolicyService;        
        //private readonly IObjectMapper ObjectMapper;


        public InsurancePolicyController(IInsurancePolicyService insurancePolicyService)
        {
            _insurancePolicyService = insurancePolicyService;            
        }

        // GET api/values
        public IList<InsurancePolicyDto> Get()
        {
            var insurancePolicies = _insurancePolicyService.GetAll();
            var result = insurancePolicies.Select(x=>new InsurancePolicyDto {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description,
                CoverageType = new CoverageDto { Id = x.CoverageType.Id, Name = x.CoverageType?.Name, Percent = x.CoverageType?.Percent },
                Period = x.Period,
                Price = x.Price,
                RiskType = x.RiskType,                
            }).ToList();
            return result;
        }


        // GET api/values/5
        public InsurancePolicyDto Get(Guid id)
        {
            var insurancePolicy = _insurancePolicyService.GetById(id);
            var result =new InsurancePolicyDto
            {
                Id = insurancePolicy.Id,
                Name = insurancePolicy.Name,
                Description = insurancePolicy.Description,
                CoverageType = new CoverageDto { Id = insurancePolicy.CoverageType.Id, Name = insurancePolicy.CoverageType?.Name, Percent = insurancePolicy.CoverageType?.Percent },
                Period = insurancePolicy.Period,
                Price = insurancePolicy.Price,
                RiskType = insurancePolicy.RiskType,
            };

            return result;
        }

        // POST api/values
        public bool Post([FromBody] InsurancePolicyDto input)
        {
            try
            {
                var data = new InsurancePolicy
                {
                    Name = input.Name,
                    Description = input.Description,
                    CoverageType = new Coverage {Name = input.CoverageType.Name, Percent = input.CoverageType.Percent, IsDeleted = false, CreationTime = DateTime.Now },
                    Period = input.Period,
                    Price = input.Price,
                    RiskType = input.RiskType,
                    IsDeleted = false,
                    CreationTime = DateTime.Now
                };
                
                _insurancePolicyService.Create(data);                
                return true;
            }
            catch (Exception e){
                return false;
            }

        }

        // PUT api/values/5
        public bool Put([FromBody] InsurancePolicyDto input)
        {
            try
            {
                var data = _insurancePolicyService.Queryable().Include(x=>x.CoverageType).FirstOrDefault(x=>x.Id == input.Id);

                data.Name = input.Name;
                data.Description = input.Description;
                data.CoverageType.Name = input.CoverageType.Name;
                data.CoverageType.Percent = input.CoverageType.Percent;
                data.CoverageType.LastModificationTime = DateTime.Now;
                data.Period = input.Period;
                data.Price = input.Price;
                data.RiskType = input.RiskType;
                data.LastModificationTime = DateTime.Now;                
                
                _insurancePolicyService.Renew(data);


                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        // DELETE api/values/5
        public bool Delete(Guid id)
        {
            try
            {               
                _insurancePolicyService.Remove(id);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

    }
}
