
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ConsoleApplication1.Model;
using ConsoleApplication1.Repository;

namespace ConsoleApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ProjetContext context = new ProjetContext();
            ProjetInitializer init = new ProjetInitializer();
            Database.SetInitializer<ProjetContext>(init);

            init.InitializeDatabase(context);
            SectionA(context);
            SectionB(context);
        }

        public static void SectionA(ProjetContext appContext)
        {

            var tutorsList = appContext.Tutor
                .Select(tutorsL => new
                {
                    lastName = tutorsL.LastName,
                    firstName = tutorsL.FirstName,
                    emailAddress = tutorsL.EmailAddress
                });
            Console.WriteLine();
            Console.WriteLine("TUTORS:");
            foreach (var tutorItr in tutorsList)
            {
                Console.WriteLine("{0}, {1}, {2}", "|" + tutorItr.lastName, "|" + tutorItr.firstName, "|" + tutorItr.emailAddress);
            }

            var helpedStudentsList = appContext.HelpedStudent
                .Select(helpStudentsL => new
                {
                    lastName = helpStudentsL.LastName,
                    firstName = helpStudentsL.FirstName,
                    emailAddress = helpStudentsL.EmailAddress
                });
            Console.WriteLine();
            Console.WriteLine("HELPED STUDENTS:");
            foreach (var helpedStudentItr in helpedStudentsList)
            {
                Console.WriteLine("{0}, {1}, {2}", "|" + helpedStudentItr.lastName, "|" + helpedStudentItr.firstName, "|" + helpedStudentItr.emailAddress);
            }
            var tutoringSessionsList = appContext.TutoringSession
                .Select(tutoringSessionsL => new
                {
                    helpedStudentName = tutoringSessionsL.Helped.LastName + " " + tutoringSessionsL.Helped.FirstName,
                    tutorName = tutoringSessionsL.Tutor.LastName + " " + tutoringSessionsL.Tutor.FirstName,
                    dateTutoring = tutoringSessionsL.DateSession,
                    lengthSession = tutoringSessionsL.LengthSession
                });
            Console.WriteLine();
            Console.WriteLine("TUTORING SESSIONS:");
            foreach (var tutoringSessionItr in tutoringSessionsList)
            {
                Console.WriteLine("{0}, {1}, {2}, {3}", "|" + tutoringSessionItr.helpedStudentName, "|" + tutoringSessionItr.tutorName, "|" + tutoringSessionItr.dateTutoring, "|" + tutoringSessionItr.lengthSession + "h");
            }
            Console.ReadLine();
        }

        protected static void SectionB(ProjetContext appContext)
        {

            var tutors = appContext.Tutor
                .GroupJoin(appContext.TutoringSession,
                tutorTable => tutorTable.Id,
                tutoringSessionTable => tutoringSessionTable.TutorId,
                (tutorTable, tutoringSessionTable) => new
                        {
                            NomFamilleTutor = tutorTable.LastName,
                            PrenomTutor = tutorTable.FirstName,
                            EmailTutor = tutorTable.EmailAddress,
                            TutoringTime = tutoringSessionTable.Sum(s => (int?)s.LengthSession) ?? 0
                        });
            Console.WriteLine();
            Console.WriteLine("TUTOR LIST WITH HOURS:");
            foreach (var tutorsItr in tutors)
            {
                Console.WriteLine("{0}, {1}, {2}, {3}", "|" + tutorsItr.NomFamilleTutor, "|" + tutorsItr.PrenomTutor, "|" + tutorsItr.EmailTutor, "|" + tutorsItr.TutoringTime + "h");
            }


            DateTime TODAY = DateTime.Now;
            var TutorsAfterToday = appContext.Tutor
                  .GroupJoin(appContext.TutoringSession,
                   tutorTable => tutorTable.Id,
                   tutoringSessionTable => tutoringSessionTable.TutorId,
                    (tutorTable, tutoringSessionTable) => new
                    {
                        NomFamilleTutor = tutorTable.LastName,
                        PrenomTutor = tutorTable.FirstName,
                        EmailTutor = tutorTable.EmailAddress,
                        TutoringTime = tutoringSessionTable.Sum(s => (int?)s.LengthSession) ?? 0,
                        LastDate = tutoringSessionTable.Where(d => (int?)d.DateSession.CompareTo(TODAY))
                        
                    }).Where(where => where.LastDate < 0);
            Console.WriteLine();
            Console.WriteLine("TUTOR LIST WITH HOURS:");
            foreach (var tutorsItr in tutors)
            {
                Console.WriteLine("{0}, {1}, {2}, {3}", "|" + tutorsItr.NomFamilleTutor, "|" + tutorsItr.PrenomTutor, "|" + tutorsItr.EmailTutor, "|" + tutorsItr.TutoringTime + "h");
            }

        }
    }
}
