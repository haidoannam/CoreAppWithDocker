using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CoreAppWithDocker.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        IAppSettings _appSettings;
        public ValuesController(IAppSettings appSettings)
        {
            _appSettings = appSettings;
        }
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" , _appSettings.EnvKey};
        }      
    }
}
