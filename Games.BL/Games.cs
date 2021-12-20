using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Games.BL
{
    public class Game
    {
        public int Id { get; set; }
        [MaxLength(30)]
        public string Name { get; set; }
        public int DeveloperId { get; set; }
        public Developer Developer { get; set; }
        public List<Genre> Genres { get; set; }
    }
}
