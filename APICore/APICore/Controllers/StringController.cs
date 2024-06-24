using APICore.Models;
using Microsoft.AspNetCore.Mvc;

namespace APICore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StringController : ControllerBase
    {

        private readonly ILogger<StringController> _logger;

        public StringController(ILogger<StringController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetString")]
        public StringModel Get()
        {
            return new StringModel
            {
                Text = "Taro",
            };
        }
    }
}
