using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CopaStefaniniBackEnd.Models.Entities
{
    public class Team
    {
        [Key]
        public int IdTeam { get; set; }
        public string Name { get; set; }
        public string NameStadium { get; set; }

        public IEnumerable<Player> ListPlayers { get; set; }

        public Team() { }

        public Team(int id, string name, string nameStadium) {
            this.IdTeam = id;
            this.Name = name;
            this.NameStadium = nameStadium;
        }

    }
}
