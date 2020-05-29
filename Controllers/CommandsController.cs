using System.Collections.Generic;
using Commander.Data;
using Commander.Models;
using Microsoft.AspNetCore.Mvc;

namespace Commander.Controllers
{
    [Route("api/commands")]
    [ApiController] // gets some default behaviors out of the box
    public class CommandsController : ControllerBase
    {
        // Initially: private readonly MockCommanderRepo _repository = new MockCommanderRepo();
        // Dependency Injection (in Startup.cs)
        private readonly ICommanderRepo _repository;
        public CommandsController(ICommanderRepo repository)
        {
            _repository = repository;
        }

        /*  /api/commands GET request */
        [HttpGet]
        public ActionResult<IEnumerable<Command>> GetAllCommands()
        {
            var commandItems = _repository.GetAppCommands();

            return Ok(commandItems);
        }

        /*  /api/commands/{id} GET request */
        [HttpGet("{id}")]
        public ActionResult<Command> GetCommandById(int id) // id comes from the request
        {
            var commandItem = _repository.GetCommandById(id);

            return Ok(commandItem);
        }
    }
}