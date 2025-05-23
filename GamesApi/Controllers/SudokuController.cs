﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using Microsoft.Extensions.Logging;

namespace GamesApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [EnableCors]
    public class SudokuController : ControllerBase
    {
        private readonly ILogger<SudokuController> _logger;

        public SudokuController(ILogger<SudokuController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetSudoku")]
        public IEnumerable<string> Test()
        {
            string[] testStrings = [ "Here is a test" ];
            return testStrings;
        }

    }
}
