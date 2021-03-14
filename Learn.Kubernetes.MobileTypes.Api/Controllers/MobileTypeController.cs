using System.Collections.Generic;
using Learn.Kubernetes.MobileTypes.Persistence;
using Learn.Kubernetes.MobileTypes.Service;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Learn.Kubernetes.MobileTypes.Api.Controllers
{
    [Route("api/[controller]")]
    public class MobileTypeController : Controller
    {
        private IMobileTypeService _mobileTypeService;
        public MobileTypeController(IMobileTypeService mobileTypeService) {

            _mobileTypeService = mobileTypeService;
        }

        [HttpGet]
        public List<MobileType> Get()
        {
            return _mobileTypeService.GetMobileTypes();
        }

        [HttpGet("id/{id}")]
        public MobileType Get(int id)
        {
            return _mobileTypeService.GetMobileTypesById(id);
        }

        [HttpGet("name/{name}")]
        public MobileType Get(string name)
        {
            return _mobileTypeService.GetMobileTypesByName(name);
        }

      
    }
}
