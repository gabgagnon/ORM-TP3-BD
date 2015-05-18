using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.Repository;
using ConsoleApplication1.Context;
using ConsoleApplication1.Model;
namespace ConsoleApplication1.Repository
{
    public class Application
    {
        public Application(ProjetContext context)
        {

        }
        
        private BaseRepository<HelpedStudent> employes;
        private BaseRepository<Tutor> tutors;
        private BaseRepository<TutoringSession> tutoringSessions;
        

        /* employes.Insert(emp1) == appContext.Employes.Add(emp3)
         * var emps = employes.GetAll()
         */
    }
}
