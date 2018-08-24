using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CopaStefaniniBackEnd.Models.Entities
{
    public class Position
    {
        [Key]
        public int IdPosition;
        public string Name;
    }
}
