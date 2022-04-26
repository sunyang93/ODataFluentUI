using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OdataFluentUI.Data.Models;

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

        [HttpPost("entitySetConfigs")]
        public IActionResult CreateEntitySetConfig(EntitySetConfig entitySetConfig)
        {
            _documentRepository.CreateEntitySetConfig(entitySetConfig);
            return Ok();
        }

        [HttpPut("entitySetConfigs/{id}")]
        public IActionResult UpdateEntitySetConfig(string id, EntitySetConfig entitySetConfig)
        {
            var _entitySetConfig = _documentRepository.GetEntitySetConfig(id);
            if (_documentRepository.UpdateEntitySetConfig(_entitySetConfig))
            {
                return NoContent();
            }
            else
            {
                return StatusCode(500);
            }
        }

        [HttpGet("entitySetConfigs/{id}")]
        public ActionResult<EntitySetConfig> GetEntitySetConfig(string id)
        {
            var entitySetConfig = _documentRepository.GetEntitySetConfig(id);
            return Ok(entitySetConfig);
        }

        [HttpDelete("entitySetConfigs/{id}")]
        public IActionResult DeleteEntitySetConfig(string id)
        {
            if(_documentRepository.DeleteEntitySetConfig(id))
            {
                return NoContent();
            }
            else
            {
                return StatusCode(500);
            }
        }
    }
}
