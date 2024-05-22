using APICours.Data;
using APICours.Models;

namespace APICours.Service
{

    public class CoursRepository : Icours
    {
        private readonly LmsContext context;
        public CoursRepository(LmsContext _context){
          context = _context;

        
        }
        public void createCours(Cours cours)
        {
          context.Cours.Add(cours);
          context.SaveChanges();
            

            //throw new NotImplementedException();
        }
    }
}
