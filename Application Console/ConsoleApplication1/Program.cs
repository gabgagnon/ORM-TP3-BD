
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
            SectionC(context);
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
                  .Join(appContext.TutoringSession,
                   tutorTable => tutorTable.Id,
                   tutoringSessionTable => tutoringSessionTable.TutorId,
                    (tutorTable, tutoringSessionTable) => new
                    {
                        NomFamilleTutor = tutorTable.LastName,
                        PrenomTutor = tutorTable.FirstName,
                        LastDate = tutoringSessionTable.DateSession.CompareTo(TODAY)

                    });
            Console.WriteLine();
            Console.WriteLine("TUTOR LIST WITH HOURS:");
            foreach (var tutorsItr in TutorsAfterToday)
            {
                if (tutorsItr.LastDate <= 0)
                    Console.WriteLine("{0}, {1}", "|" + tutorsItr.NomFamilleTutor, "|" + tutorsItr.PrenomTutor);
            }

            Console.ReadLine();


        }

        
        protected static void SectionC(ProjetContext appContext)
        {
            Tutor tutorToUpgrade;
            tutorToUpgrade = appContext.Tutor.Where(t => t.FirstName == "Gary" && t.LastName == "Bilodeau").FirstOrDefault<Tutor>();

            if (tutorToUpgrade != null)
            {
                tutorToUpgrade.EmailAddress = "gbilodeau@invalidemail.com";
            }


            HelpedStudent helpedStudentToUpgrade;
            helpedStudentToUpgrade = appContext.HelpedStudent.Where(hs => hs.FirstName == "Marc" && hs.LastName == "Arsenault").FirstOrDefault<HelpedStudent>();
            TutoringSession TutoringSessionOfHelpedStudentToUpgrade;
            TutoringSessionOfHelpedStudentToUpgrade = appContext.TutoringSession.Where(s => s.Helped.Id == helpedStudentToUpgrade.Id).FirstOrDefault();
            appContext.TutoringSession.Remove(TutoringSessionOfHelpedStudentToUpgrade);
            appContext.HelpedStudent.Remove(helpedStudentToUpgrade);
            appContext.SaveChanges();


            HelpedStudent helpedStudentToUpgrade02;
            helpedStudentToUpgrade02 = appContext.HelpedStudent.Where(hs => hs.FirstName == "Marc" && hs.LastName == "Arsenault").FirstOrDefault<HelpedStudent>();
            TutoringSession TutoringSessionToUpgrade;
            TutoringSessionToUpgrade = appContext.TutoringSession.Where(ts => ts.Helped.Id == helpedStudentToUpgrade02.Id).FirstOrDefault<TutoringSession>();

            if (tutorToUpgrade != null)
            {
                TutoringSessionToUpgrade.DateSession = new DateTime(2015, 04, 09, 11, 0, 0);
                TutoringSessionToUpgrade.TimeSession = 2;
            }
            appContext.SaveChanges();

            HelpedStudent helpedStudentToJoin;
            helpedStudentToJoin = appContext.HelpedStudent.Where(hs => hs.FirstName == "Samuel" && hs.LastName == "Vachon").FirstOrDefault<HelpedStudent>();
            Tutor TutorToJoin;
            TutorToJoin = appContext.Tutor.Where(hs => hs.FirstName == "Louis" && hs.LastName == "Vézina").FirstOrDefault<Tutor>();
            TutoringSession newTutoringSession = new TutoringSession()
            {
                DateSession = new DateTime(2015, 06, 04, 10, 0, 0),
                TimeSession = 10,
                LengthSession = 2,
                Helped = helpedStudentToJoin,
                Tutor = TutorToJoin
            };
            appContext.TutoringSession.Add(newTutoringSession);
            appContext.SaveChanges();
        }
    }



}
