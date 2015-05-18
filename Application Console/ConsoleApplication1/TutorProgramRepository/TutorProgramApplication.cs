using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.TutorProgramRepository
{
    class TutorProgramApplication (ProjectContext context)
    {
        private sinapseRepository<Employe> employes;
        private sinapseRepository<Tutor> tutors;
        private sinapseRepository<TutoringSession> tutoringSessions;

        /* employes.Insert(emp1) == appContext.Employes.Add(emp3)
         * var emps = employes.GetAll()
         */
    }
}
