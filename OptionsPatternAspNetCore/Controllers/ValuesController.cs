using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using OptionsPatternAspNetCore.Models;

namespace OptionsPatternAspNetCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IOptions<ElasticSearchConfig> _elasticSearchConfig;
        public ValuesController(IOptions<ElasticSearchConfig> elasticSearchConfig)
        {
            _elasticSearchConfig = elasticSearchConfig;
        }
        
        [HttpGet]
        public ActionResult<Uri[]> GetElasticConfig()
        {
            return _elasticSearchConfig.Value.Nodes;
        }
    }
}
