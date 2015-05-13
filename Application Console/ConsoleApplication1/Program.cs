
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
                foreach (var tutor in tutorsList)
                {
                    Console.WriteLine("{0}, {1}, {2}", "|" + tutor.lastName, "|" + tutor.firstName, "|" + tutor.emailAddress);
                }

                var helpedStudentsList = appContext.HelpedStudent
                    .Select(helpStudentsL => new
                    {
                        lastName =  helpStudentsL.LastName,
                        firstName = helpStudentsL.FirstName,
                        emailAddress = helpStudentsL.EmailAddress
                    });
                Console.WriteLine();
                Console.WriteLine("HELPED STUDENTS:");
                foreach (var helpedStudent in helpedStudentsList)
                {
                    Console.WriteLine("{0}, {1}, {2}", "|" + helpedStudent.lastName, "|" + helpedStudent.firstName, "|" + helpedStudent.emailAddress);
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
                foreach (var tutoringSession in tutoringSessionsList)
                {
                    Console.WriteLine("{0}, {1}, {2}, {3}", "|" + tutoringSession.helpedStudentName, "|" + tutoringSession.tutorName, "|" + tutoringSession.dateTutoring, "|" + tutoringSession.lengthSession + "h");
                }
                Console.ReadLine();
            }
       
            protected static void SectionB(ProjetContext appContext)
            {
                /*
                var tutors = appContext.Tutor
                    .Join(appContext.TutoringSession,
                    tutorTable => tutorTable.Id,
                    tutoringSessionTable => tutoringSessionTable.TutorId,
                    (tutorTable, tutoringSessionTable) => new
                            {
                                tutorTable.LastName,
                                tutorTable.FirstName,
                                tutorTable.EmailAddress,
                                TutoringTime  = 
                               

                            });
                */
            }
    }
}
