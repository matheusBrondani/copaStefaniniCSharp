using System.Collections.Generic;
using System.Net.Http;
using CopaStefaniniBackEnd.Models.Entities;
using CopaStefaniniBackEnd.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CopaStefaniniBackEnd.Controllers
{
    [Produces("application/json")]
    [Route("api/Player")]
    public class PlayerController : Controller
    {
        private  PlayerService job;

        public PlayerController(PlayerService _job)
        {
            job = _job;
        }

        // GET: api/Jogador
        [HttpGet]
        public IEnumerable<Player> Get()
        {
            return job.GetAllPlayers();
        }

        // GET: api/Jogador/5
        [HttpGet("{id}", Name = "Get")]
        public ActionResult Get(int id)
        {
            var player = job.GetPlayerById(id);

            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            if (player == null) {
                return NotFound();
            }

            return Ok(player);
        }
        
        // POST: api/Jogador
        [HttpPost]
        public Player Post([FromBody] Player newPlayer)
        {
            job.PostPlayer(newPlayer);
            return newPlayer;
        }
        
        // PUT: api/Jogador/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Player upPlayer)
        {
            job.PutPlayer(id, upPlayer);
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            job.DeletePlayer(id);
        }
    }
}
