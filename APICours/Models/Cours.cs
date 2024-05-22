using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APICours.Models
{
    public class Cours
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public string TypeCours   { get; set; }

        public float Price { get; set; }
        
        public  ICollection<Lecon> leslecons { get; set; } =new List<Lecon>();

    }
}
