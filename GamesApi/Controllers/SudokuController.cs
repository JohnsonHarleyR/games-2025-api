using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using Microsoft.Extensions.Logging;

namespace GamesApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [EnableCors]
    public class SudokuController : ControllerBase
    {
        private readonly ILogger<SudokuController> _logger;

        public SudokuController(ILogger<SudokuController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ActionResult Test()
        {
            return new JsonResult("Here is a test, did it work?");
        }

    }
}
