using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VerzorgingApp.Server.Models;
using VerzorgingApp.Shared;

namespace VerzorgingApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupervisorController : ControllerBase
    {
        private readonly ISupervisorRepo _supervisorrepo;

        public SupervisorController(ISupervisorRepo supervisorRepository)
        {
            _supervisorrepo = supervisorRepository;
        }

        [HttpGet]
        public IActionResult GetAllSupervisors()
        {
            return Ok(_supervisorrepo.GetAllSupervisors());
        }

        [HttpGet("{id}")]
        public IActionResult GetSupervisorById(int id)
        {
            return Ok(_supervisorrepo.GetSupervisorById(id));
        }

        [HttpPost]
        public IActionResult CreateSupervisor([FromBody] Supervisor supervisor)
        {
            if (supervisor == null)
                return BadRequest();

            if (supervisor.FirstName == string.Empty || supervisor.LastName == string.Empty)
            {
                ModelState.AddModelError("Name/FirstName", "The name or first name shouldn't be empty");
            }

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var createdSupervisor = _supervisorrepo.AddSupervisor(supervisor);

            return Created("supervisor", createdSupervisor);
        }

        [HttpPut]
        public IActionResult UpdateSupervisor([FromBody] Supervisor supervisor)
        {
            if (supervisor == null)
                return BadRequest();

            if (supervisor.FirstName == string.Empty || supervisor.LastName == string.Empty)
            {
                ModelState.AddModelError("Name/FirstName", "The name or first name shouldn't be empty");
            }

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var supervisorToUpdate = _supervisorrepo.GetSupervisorById(supervisor.Id);

            if (supervisorToUpdate == null)
                return NotFound();

            _supervisorrepo.UpdateSupervisor(supervisor);

            return NoContent(); //success
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteSupervisor(int id)
        {
            if (id == 0)
                return BadRequest();

            var supervisorToDelete = _supervisorrepo.GetSupervisorById(id);
            if (supervisorToDelete == null)
                return NotFound();

            _supervisorrepo.DeleteSupervisor(id);

            return NoContent();//success
        }
    }
}
