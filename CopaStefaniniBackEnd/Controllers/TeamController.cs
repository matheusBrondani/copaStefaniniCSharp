using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using CopaStefaniniBackEnd.Models.Entities;
using CopaStefaniniBackEnd.Services;


namespace CopaStefaniniBackEnd.Controllers
{    
    [Route("api/Team")]    
    public class TeamController : Controller
    {
        private readonly TeamService job;

        public TeamController(TeamService _job)
        {
            job = _job;
        }

        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<Team> Get()
        {
            return job.GetAllTeamsWithPlayers();
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public Team Get(int id)
        {
            return job.GetTeamById(id);
        }

        // POST api/<controller>
        [HttpPost]
        public void Post(Team newTeam)
        {
            job.PostTeam(newTeam);
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, Team upTeam)
        {
            job.PutTeam(id, upTeam);
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            job.DeleteTeam(id);
        }
    }
}
