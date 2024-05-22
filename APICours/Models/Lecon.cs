using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APICours.Models
{
    public class Lecon
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int coursId { get; set; }
        public Cours Cours { get; set; }
    }
} 