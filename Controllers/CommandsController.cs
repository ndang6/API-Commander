using System.Collections.Generic;
using AutoMapper;
using Commander.Data;
using Commander.Dtos;
using Commander.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace Commander.Controllers
{
    [Route("api/commands")]
    [EnableCors("MyPolicy")]
    [ApiController] // gets some default behaviors out of the box
    public class CommandsController : ControllerBase
    {
        // Initially: private readonly MockCommanderRepo _repository = new MockCommanderRepo();
        // Dependency Injection (in Startup.cs)
        private readonly ICommanderRepo _repository;
        private readonly IMapper _mapper;

        public CommandsController(ICommanderRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        /*GET  /api/commands */
        [HttpGet]
        public ActionResult<IEnumerable<CommandReadDto>> GetAllCommands()
        {
            var commandItems = _repository.GetAllCommands();

            return Ok(_mapper.Map<IEnumerable<CommandReadDto>>(commandItems));
        }

        /*GET  /api/commands/{id} */
        [HttpGet("{id}")]
        public ActionResult<CommandReadDto> GetCommandById(int id) // id comes from the request
        {
            var commandItem = _repository.GetCommandById(id);
            if (commandItem != null)
                return Ok(_mapper.Map<CommandReadDto>(commandItem));

            return NotFound();
        }
    }
}