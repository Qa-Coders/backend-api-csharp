using APIT5MD2.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIT5MD2.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly ILogger<PersonController> _logger;
        private readonly IPersonRepository _personRepository;

        public PersonController(ILogger<PersonController> logger, IPersonRepository personRepository)
        {
            _logger = logger;
            _personRepository = personRepository;
        }

        [HttpGet]
        public IActionResult GetAllData()
        {
            try
            {
                var data = _personRepository.ListAll();
                return Ok(data);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro a consultar os dados");
                return new StatusCodeResult(500);
            }
        }

        [HttpPost]
        public IActionResult SetData([FromBody] long step)
        {
            try
            {
                var result = _personRepository.Insert(step);
                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao tentar inserir os dados");
                return new StatusCodeResult(500);
            }
        }
    }
}
