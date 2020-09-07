using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Namacha.Commander.Data;
using Namacha.Commander.Models;

namespace Namacha.Commander.Controllers
{
    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly ICommanderRepo _repository;

        public CommandsController(ICommanderRepo repository)
        {
            _repository = repository;
        }
       
        [HttpGet]
        public ActionResult<IEnumerable<Command>> GetAllCommands()
        {
            var commanderItems = _repository.GetAllCommands();
            return Ok(commanderItems);
        }


        [HttpGet]
        [Route("{id}")]
        public ActionResult<Command> GetCommandById(int id)
        {
            var commanditem = _repository.GetCommandById(id);
            return Ok(commanditem);
        }
    }

}
