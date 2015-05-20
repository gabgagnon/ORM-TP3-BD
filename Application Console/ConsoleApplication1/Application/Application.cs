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
         private BaseRepository<Tutor> repoTutors;
         private BaseRepository<HelpedStudent> repoHelpedStudents;
         private BaseRepository<TutoringSession> repoTutoringSessions;

    public Application(ProjetContext context)
        {
            Seed();
            SectionA();
            SectionB();
            SectionC(context);
        }
    public void Seed()
        {

            Tutor newTutor1 = new Tutor()
            {
                LastName = "Bilodeau",
                FirstName = "Gary",
                EmailAddress = "bgary2@hotmail.com"
            };
            Tutor newTutor2 = new Tutor()
            {
                LastName = "Gagnon",
                FirstName = "Samuel",
                EmailAddress = "samPP92@hotmail.com"
            };
            Tutor newTutor3 = new Tutor()
            {
                LastName = "Gingras",
                FirstName = "Simon",
                EmailAddress = "ptitguy22@bell.net"
            };
            Tutor newTutor4 = new Tutor()
            {
                LastName = "Roy",
                FirstName = "Éric",
                EmailAddress = "eroy231@videotron.ca"
            };
            Tutor newTutor5 = new Tutor()
            {
                LastName = "Veilleux",
                FirstName = "Caroline",
                EmailAddress = "caro.koko@hotmail.com"
            };
            Tutor newTutor6 = new Tutor()
            {
                LastName = "Tremblay",
                FirstName = "Karine",
                EmailAddress = "kar.tremblay@gmail.com"
            };
            Tutor newTutor7 = new Tutor()
            {
                LastName = "Vézina",
                FirstName = "Louis",
                EmailAddress = "vl410Bd@gmail.com"
            };
         
            repoTutors.Insert(newTutor2);
            repoTutors.Insert(newTutor3);
            repoTutors.Insert(newTutor4);
            repoTutors.Insert(newTutor5);
            repoTutors.Insert(newTutor6);
            repoTutors.Insert(newTutor7);

            HelpedStudent newHelpedStudent1 = new HelpedStudent()
            {
                LastName = "Arsenault",
                FirstName = "Marc",
                EmailAddress = "marco.arso@hotmail.com"
            };
            HelpedStudent newHelpedStudent2 = new HelpedStudent()
            {
                LastName = "Boilard",
                FirstName = "Éric",
                EmailAddress = "eric.r.boilard2@coop.com"
            };
            HelpedStudent newHelpedStudent3 = new HelpedStudent()
            {
                LastName = "Couture",
                FirstName = "Jean-Cristophe",
                EmailAddress = "jc.couture.wilde@hotmail.com"
            };
            HelpedStudent newHelpedStudent4 = new HelpedStudent()
            {
                LastName = "Desrosiers",
                FirstName = "Julianne",
                EmailAddress = "galypo13@hotmail.com"
            };
            HelpedStudent newHelpedStudent5 = new HelpedStudent()
            {
                LastName = "Grégoire-Allen",
                FirstName = "Léo",
                EmailAddress = "leoga@hotmail.com"
            };
            HelpedStudent newHelpedStudent6 = new HelpedStudent()
            {
                LastName = "Hamel",
                FirstName = "François",
                EmailAddress = "GLA@Gmail.com"
            };
            HelpedStudent newHelpedStudent7 = new HelpedStudent()
            {
                LastName = "Lepage",
                FirstName = "Jérémy",
                EmailAddress = "LJ@Gmail.com"
            };
            HelpedStudent newHelpedStudent8 = new HelpedStudent()
            {
                LastName = "Poitras",
                FirstName = "Nicolas",
                EmailAddress = "PN@Gmail.com"
            };
            HelpedStudent newHelpedStudent9 = new HelpedStudent()
            {
                LastName = "Roy-Gagnon",
                FirstName = "Samuel",
                EmailAddress = "RGS@Gmail.com"
            };
            HelpedStudent newHelpedStudent10 = new HelpedStudent()
            {
                LastName = "Simard",
                FirstName = "Benjamin",
                EmailAddress = "BS@Gmail.com"
            };
            HelpedStudent newHelpedStudent11 = new HelpedStudent()
            {
                LastName = "Vachon",
                FirstName = "Samuel",
                EmailAddress = "VS@Gmail.com"
            };
            
            repoHelpedStudents.Insert(newHelpedStudent1);
            repoHelpedStudents.Insert(newHelpedStudent2);
            repoHelpedStudents.Insert(newHelpedStudent3);
            repoHelpedStudents.Insert(newHelpedStudent4);
            repoHelpedStudents.Insert(newHelpedStudent5);
            repoHelpedStudents.Insert(newHelpedStudent6);
            repoHelpedStudents.Insert(newHelpedStudent7);
            repoHelpedStudents.Insert(newHelpedStudent8);
            repoHelpedStudents.Insert(newHelpedStudent9);
            repoHelpedStudents.Insert(newHelpedStudent10);
            repoHelpedStudents.Insert(newHelpedStudent11);


            TutoringSession newTutoringSession1 = new TutoringSession()
            {
                DateSession = new DateTime(2015, 03, 16, 13, 0, 0),
                TimeSession = 13,
                LengthSession = 2,
                Helped = newHelpedStudent5,
                Tutor = newTutor5
            };
            TutoringSession newTutoringSession2 = new TutoringSession()
            {
                DateSession = new DateTime(2015, 03, 24, 10, 0, 0),
                TimeSession = 10,
                LengthSession = 1,
                Helped = newHelpedStudent5,
                Tutor = newTutor1
            };
            TutoringSession newTutoringSession3 = new TutoringSession()
            {
                DateSession = new DateTime(2015, 03, 25, 13, 0, 0),
                TimeSession = 13,
                LengthSession = 1,
                Helped = newHelpedStudent2,
                Tutor = newTutor4
            };
            TutoringSession newTutoringSession4 = new TutoringSession()
            {
                DateSession = new DateTime(2015, 04, 01, 12, 0, 0),
                TimeSession = 12,
                LengthSession = 2,
                Helped = newHelpedStudent1,
                Tutor = newTutor5
            };
            TutoringSession newTutoringSession5 = new TutoringSession()
            {
                DateSession = new DateTime(2015, 04, 01, 13, 0, 0),
                TimeSession = 13,
                LengthSession = 1,
                Helped = newHelpedStudent2,
                Tutor = newTutor3
            };
            TutoringSession newTutoringSession6 = new TutoringSession()
            {
                DateSession = new DateTime(2015, 04, 06, 16, 0, 0),
                TimeSession = 16,
                LengthSession = 1,
                Helped = newHelpedStudent1,
                Tutor = newTutor4
            };
            TutoringSession newTutoringSession7 = new TutoringSession()
            {
                DateSession = new DateTime(2015, 04, 08, 10, 0, 0),
                TimeSession = 10,
                LengthSession = 1,
                Helped = newHelpedStudent6,
                Tutor = newTutor4
            };
            TutoringSession newTutoringSession8 = new TutoringSession()
            {
                DateSession = new DateTime(2015, 04, 10, 10, 0, 0),
                TimeSession = 10,
                LengthSession = 2,
                Helped = newHelpedStudent1,
                Tutor = newTutor4
            };
            TutoringSession newTutoringSession9 = new TutoringSession()
            {
                DateSession = new DateTime(2015, 04, 29, 12, 0, 0),
                TimeSession = 12,
                LengthSession = 1,
                Helped = newHelpedStudent9,
                Tutor = newTutor5
            };
            TutoringSession newTutoringSession10 = new TutoringSession()
            {
                DateSession = new DateTime(2015, 05, 25, 13, 0, 0),
                TimeSession = 13,
                LengthSession = 1,
                Helped = newHelpedStudent10,
                Tutor = newTutor7
            };
            TutoringSession newTutoringSession11 = new TutoringSession()
            {
                DateSession = new DateTime(2015, 05, 27, 12, 0, 0),
                TimeSession = 12,
                LengthSession = 2,
                Helped = newHelpedStudent10,
                Tutor = newTutor5
            };
            TutoringSession newTutoringSession12 = new TutoringSession()
            {
                DateSession = new DateTime(2015, 05, 27, 13, 0, 0),
                TimeSession = 13,
                LengthSession = 1,
                Helped = newHelpedStudent2,
                Tutor = newTutor3
            };
            TutoringSession newTutoringSession13 = new TutoringSession()
            {
                DateSession = new DateTime(2015, 06, 01, 9, 0, 0),
                TimeSession = 9,
                LengthSession = 1,
                Helped = newHelpedStudent7,
                Tutor = newTutor7
            };
            TutoringSession newTutoringSession14 = new TutoringSession()
            {
                DateSession = new DateTime(2015, 06, 02, 9, 0, 0),
                TimeSession = 9,
                LengthSession = 1,
                Helped = newHelpedStudent11,
                Tutor = newTutor7
            };
            TutoringSession newTutoringSession15 = new TutoringSession()
            {
                DateSession = new DateTime(2015, 06, 02, 11, 0, 0),
                TimeSession = 11,
                LengthSession = 1,
                Helped = newHelpedStudent2,
                Tutor = newTutor7
            };
            TutoringSession newTutoringSession16 = new TutoringSession()
            {
                DateSession = new DateTime(2015, 06, 02, 13, 0, 0),
                TimeSession = 13,
                LengthSession = 1,
                Helped = newHelpedStudent5,
                Tutor = newTutor1
            };
            TutoringSession newTutoringSession17 = new TutoringSession()
            {
                DateSession = new DateTime(2015, 06, 02, 15, 0, 0),
                TimeSession = 15,
                LengthSession = 1,
                Helped = newHelpedStudent9,
                Tutor = newTutor1
            };
            TutoringSession newTutoringSession18 = new TutoringSession()
            {
                DateSession = new DateTime(2015, 06, 03, 13, 0, 0),
                TimeSession = 13,
                LengthSession = 2,
                Helped = newHelpedStudent7,
                Tutor = newTutor3
            };

            repoTutoringSessions.Insert(newTutoringSession1);
            repoTutoringSessions.Insert(newTutoringSession2);
            repoTutoringSessions.Insert(newTutoringSession3);
            repoTutoringSessions.Insert(newTutoringSession4);
            repoTutoringSessions.Insert(newTutoringSession5);
            repoTutoringSessions.Insert(newTutoringSession6);
            repoTutoringSessions.Insert(newTutoringSession7);
            repoTutoringSessions.Insert(newTutoringSession8);
            repoTutoringSessions.Insert(newTutoringSession9);
            repoTutoringSessions.Insert(newTutoringSession10);
            repoTutoringSessions.Insert(newTutoringSession11);
            repoTutoringSessions.Insert(newTutoringSession12);
            repoTutoringSessions.Insert(newTutoringSession13);
            repoTutoringSessions.Insert(newTutoringSession14);
            repoTutoringSessions.Insert(newTutoringSession15);
            repoTutoringSessions.Insert(newTutoringSession16);
            repoTutoringSessions.Insert(newTutoringSession17);
            repoTutoringSessions.Insert(newTutoringSession18);

        }

    public void SectionA()
    {

        var tutorsList = repoTutors.GetAll();
        Console.WriteLine();
        Console.WriteLine("TUTORS:");
        foreach (var tutorItr in tutorsList)
        {
            Console.WriteLine("{0}, {1}, {2}", "|" + tutorItr.LastName + "|" + tutorItr.FirstName, "|" + tutorItr.EmailAddress);
        }

        var helpedStudentsList = repoHelpedStudents.GetAll();
        Console.WriteLine();
        Console.WriteLine("HELPED STUDENTS:");
        foreach (var helpedStudentItr in helpedStudentsList)
        {
            Console.WriteLine("{0}, {1}, {2}", "|" + helpedStudentItr.LastName, "|" + helpedStudentItr.FirstName, "|" + helpedStudentItr.EmailAddress);
        }
        var tutoringSessionsList = repoTutoringSessions.GetAll();
        Console.WriteLine();
        Console.WriteLine("TUTORING SESSIONS:");
        foreach (var tutoringSessionItr in tutoringSessionsList)
        {
            Console.WriteLine("{0}, {1}, {2}, {3}", "|" + tutoringSessionItr.Helped.FirstName, "|" + tutoringSessionItr.Tutor.LastName, "|" + tutoringSessionItr.DateSession, "|" + tutoringSessionItr.LengthSession + "h");
        }
        Console.ReadLine();
    }

    protected void SectionB()
    {
       // C'était un désastre durant la remise 2. je ne l'ai pas mis dans la remise 3.
    }


    protected void SectionC(ProjetContext appContext)
    {
        Tutor tutorToUpgrade;
        tutorToUpgrade = appContext.Tutor.Where(t => t.FirstName == "Gary" && t.LastName == "Bilodeau").FirstOrDefault<Tutor>();

        if (tutorToUpgrade != null)
        {
            tutorToUpgrade.EmailAddress = "gbilodeau@invalidemail.com";
            repoTutors.Update(tutorToUpgrade);
        }


        HelpedStudent helpedStudentToDelete;
        helpedStudentToDelete = appContext.HelpedStudent.Where(hs => hs.FirstName == "Marc" && hs.LastName == "Arsenault").FirstOrDefault<HelpedStudent>();
        TutoringSession TutoringSessionOfHelpedStudentToDelete;
        TutoringSessionOfHelpedStudentToDelete = appContext.TutoringSession.Where(s => s.HelpedId == helpedStudentToDelete.Id).FirstOrDefault();

        repoTutoringSessions.Delete(TutoringSessionOfHelpedStudentToDelete);
        repoHelpedStudents.Delete(helpedStudentToDelete);



        HelpedStudent helpedStudentToUpgrade02;
        helpedStudentToUpgrade02 = appContext.HelpedStudent.Where(hs => hs.FirstName == "Marc" && hs.LastName == "Arsenault").FirstOrDefault<HelpedStudent>();
        TutoringSession TutoringSessionToUpgrade;
        TutoringSessionToUpgrade = appContext.TutoringSession.Where(ts => ts.Helped.Id == helpedStudentToUpgrade02.Id).FirstOrDefault<TutoringSession>();

        if (tutorToUpgrade != null)
        {
            TutoringSessionToUpgrade.DateSession = new DateTime(2015, 04, 09, 11, 0, 0);
            TutoringSessionToUpgrade.TimeSession = 11;
            repoTutoringSessions.Update(TutoringSessionToUpgrade);
        }

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
        repoTutoringSessions.Insert(newTutoringSession);
    }
    }
}
