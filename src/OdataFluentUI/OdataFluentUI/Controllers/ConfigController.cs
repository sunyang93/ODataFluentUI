using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OdataFluentUI.Core.Infrastructure;

namespace OdataFluentUI.Controllers
{
    [Route("api/configs")]
    [ApiController]
    public class ConfigController : ControllerBase
    {
        private readonly IDocumentRepository _documentRepository;
        public ConfigController(IDocumentRepository documentRepository)
        {
            _documentRepository = documentRepository;
        }

        [HttpGet]
        public IActionResult Test()
        {
            _documentRepository.Test();
            return Ok();
        }
    }
}
