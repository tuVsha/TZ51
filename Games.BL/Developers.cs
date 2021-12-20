using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Games.BL
{
    public class Developer
    {
        public int Id { get; set; }
        [MaxLength(30)]
        public string Name { get; set; }
        public List<Game> Games { get; set; }
    }
}
