using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Learn.Kubernetes.MobileTypes.Service;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Learn.Kubernetes.MobileTypes.Api.Controllers
{
    [Route("api/[controller]")]
    public class HealthProbeController : Controller
    {
        private readonly IHealthProbeService _healthProbeService;

        public HealthProbeController(IHealthProbeService healthProbeService) {

            _healthProbeService = healthProbeService;


        }

        [HttpGet]
        public bool Get()
        {
            return _healthProbeService.HealthProbe();

        }

       
    }
}
