using APICours.Models;

namespace APICours.Dtos
{
    public class CoursDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string TypeCours { get; set; }

        public float Price { get; set; }

        public ICollection<LeconDto> leslecons { get; set; }
    }
}
