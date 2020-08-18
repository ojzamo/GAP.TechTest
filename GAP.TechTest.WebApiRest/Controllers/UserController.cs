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
    public class UserController : ApiController
    {

        private readonly IUserService _userService;        
        //private readonly IObjectMapper ObjectMapper;


        public UserController(IUserService userService)
        {
            _userService = userService;            
        }

        // POST api/values
        public bool Create([FromBody]  UserDto user)
        {
            try
            {
                var data = new User
                {
                  EmailAddress = user.EmailAddress,
                  Password = user.Password,
                  Name = user.Name,
                  Surname = user.Surname,
                  UserName = user.UserName,
                  CreationTime = DateTime.Now
                };

                _userService.Create(data);                
                return true;
            }
            catch (Exception e){
                return false;
            }

        }

        public IList<UserDto> Get()
        {
            var insurancePolicies = _userService.GetAll();
            var result = insurancePolicies.Select(x => new UserDto
            {
                Id = x.Id,
                Name = x.Name,
                Surname = x.Surname,
                UserName = x.UserName
            }).ToList();
            return result;
        }

    }
}
