using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CopaStefaniniBackEnd.Models.Entities
{
    public class Player
    {
        [Key]
        public int? IdPlayer { get; set; }
        public string Name { get; set; }
        public int? Position { get; set; }
        public int? Shirt { get; set; }        
        public int? Cap { get; set; }
        public bool? Holder { get; set; }

        public int? IdTeam { get; set; }

        public Player() { }

        public Player(int id, string Name, int Position, int Shirt, int? idTeam, int? Cap, bool Holder) {
            this.IdPlayer = id;
            this.Name = Name;
            this.Position = Position;
            this.Shirt = Shirt;
            this.IdTeam = idTeam;
            this.Cap = Cap;
            this.Holder = Holder;
        }
    }
}
