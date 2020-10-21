using System.Collections.Generic;
using CommandFinder.Data;
using CommandFinder.Models;
using Microsoft.AspNetCore.Mvc;

namespace CommandFinder.Controllers
{
    // //api/commands -dynamic
    // [Route("api/[controller]")]

    // api/commads -static
    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly ICommandFinderRepo _repository;
        public CommandsController(ICommandFinderRepo repository)
        {
            _repository = repository;
        }
        //private readonly MockCommandFinderRepo _repository = new MockCommandFinderRepo();
        // GET api/commands   -all of the commands
        [HttpGet]
        public ActionResult <IEnumerable<Command>> GetAllCommands()
        {
            var commandItems = _repository.GetAppCommands();
            return Ok(commandItems);
        }

        // GET api/commands/{id}    -specific id
        [HttpGet("{id}")]
        public ActionResult <Command> GetCommandById(int id)
        {
            var commandItem = _repository.GetCommandById(id);
            return Ok(commandItem);
        }     
    }
}