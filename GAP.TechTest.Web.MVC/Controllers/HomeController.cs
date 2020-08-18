using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using GAP.TechTest.Web.MVC.Models;
using Microsoft.IdentityModel.Protocols;
using Microsoft.Extensions.Configuration;
using RestSharp;
using System.Net;
using Newtonsoft.Json;
using Polly;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GAP.TechTest.Web.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly string _olApiUrl;

        public HomeController(ILogger<HomeController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _olApiUrl = configuration.GetValue<string>("OlApiUrl");
        }

        public IActionResult Index()
        {
            try
            {
                IndexModel model = new IndexModel();
                var client = new RestClient(_olApiUrl);
                var request = new RestRequest("api/InsurancePolicy", Method.GET);
                IRestResponse response = null;
                Policy.Handle<Exception>()
                    .Retry(3, (exception, retryCount, context) => { _logger.LogWarning(exception, "Retry"); })
                    .Execute(() => response = client.Execute(request));
                var list = JsonConvert.DeserializeObject<IList<InsurancePolicyModel>>(response.Content);
                model.InsurancePolicyList = list;
                return View("Index",model);
            }
            catch (Exception exception)
            {
                _logger.LogError(exception, "There was an exception");
                throw;
            }   
        }

        public IActionResult Privacy()
        {
            return View();
        }
        #region Edit
        public IActionResult Edit(Guid id)
        {
            var client = new RestClient(_olApiUrl);
            var request = new RestRequest($"api/InsurancePolicy/{id}", Method.GET);
            IRestResponse response = null;
            Policy.Handle<Exception>()
                .Retry(3, (exception, retryCount, context) => { _logger.LogWarning(exception, "Retry"); })
                .Execute(() => response = client.Execute(request));
            var model = JsonConvert.DeserializeObject<InsurancePolicyModel>(response.Content);
            return View(model);
        }

        public IActionResult EditSave(InsurancePolicyModel input)
        {
            var client = new RestClient(_olApiUrl);
            var request = new RestRequest($"api/InsurancePolicy", Method.PUT);
            request.AddJsonBody(input);
            IRestResponse response = null;
            Policy.Handle<Exception>()
                .Retry(3, (exception, retryCount, context) => { _logger.LogWarning(exception, "Retry"); })
                .Execute(() => response = client.Execute(request));

            return Index();
        }
        #endregion

        #region New
        public IActionResult New()
        {            
            return View();
        }

        public IActionResult NewSave(InsurancePolicyModel input)
        {
            var client = new RestClient(_olApiUrl);
            var request = new RestRequest($"api/InsurancePolicy", Method.POST);
            request.AddJsonBody(input);
            IRestResponse response = null;
            Policy.Handle<Exception>()
                .Retry(3, (exception, retryCount, context) => { _logger.LogWarning(exception, "Retry"); })
                .Execute(() => response = client.Execute(request));

            return Index();
        }
        #endregion

        #region assign
        public IActionResult Assign(Guid id)
        {
            var client = new RestClient(_olApiUrl);
            var request = new RestRequest($"api/InsurancePolicy/{id}", Method.GET);
            IRestResponse response = null;
            Policy.Handle<Exception>()
                .Retry(3, (exception, retryCount, context) => { _logger.LogWarning(exception, "Retry"); })
                .Execute(() => response = client.Execute(request));
            var insurancePolicy = JsonConvert.DeserializeObject<InsurancePolicyModel>(response.Content);
            var model = new AssignModel { InsurancePolicyId = insurancePolicy.Id, Name = insurancePolicy.Name };

            request = new RestRequest("api/User", Method.GET);
            response = null;
            Policy.Handle<Exception>()
                .Retry(3, (exception, retryCount, context) => { _logger.LogWarning(exception, "Retry"); })
                .Execute(() => response = client.Execute(request));
            var users = JsonConvert.DeserializeObject<IList<UserModel>>(response.Content);

            ViewBag.Users = users
                 .Select(x => new SelectListItem
                 {
                     Value = x.Id.ToString(),
                     Text = $"{x.Name} {x.Surname}"
                 })
                 .ToList();

            return View(model);
        }

        public IActionResult AssignSave(AssignModel input)
        {
            var client = new RestClient(_olApiUrl);
            var request = new RestRequest($"/api/UserPolicy", Method.POST);
            request.AddJsonBody(input);
            IRestResponse response = null;
            Policy.Handle<Exception>()
                .Retry(3, (exception, retryCount, context) => { _logger.LogWarning(exception, "Retry"); })
                .Execute(() => response = client.Execute(request));

            return Index();
        }
        #endregion

        public IActionResult Remove(Guid id)
        {
            var client = new RestClient(_olApiUrl);
            var request = new RestRequest($"api/InsurancePolicy/{id}", Method.DELETE);
            IRestResponse response = null;
            Policy.Handle<Exception>()
                .Retry(3, (exception, retryCount, context) => { _logger.LogWarning(exception, "Retry"); })
                .Execute(() => response = client.Execute(request));
            
            return Index();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
