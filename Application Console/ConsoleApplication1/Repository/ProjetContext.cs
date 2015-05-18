using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

using ConsoleApplication1.Model;

namespace ConsoleApplication1.Repository
{
    public class ProjetContext : DbContext
    {
          public DbSet<Tutor> Tutor { get; set; }
          public DbSet<HelpedStudent> HelpedStudent { get; set; }
          public DbSet<TutoringSession> TutoringSession { get; set; }
    }

    public class ProjetInitializer : DropCreateDatabaseIfModelChanges<ProjetContext>
    {
        protected override void Seed(ProjetContext appContext)
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

            appContext.Tutor.Add(newTutor1);
            appContext.Tutor.Add(newTutor2);
            appContext.Tutor.Add(newTutor3);
            appContext.Tutor.Add(newTutor4);
            appContext.Tutor.Add(newTutor5);
            appContext.Tutor.Add(newTutor6);
            appContext.Tutor.Add(newTutor7);

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

            appContext.HelpedStudent.Add(newHelpedStudent1);
            appContext.HelpedStudent.Add(newHelpedStudent2);
            appContext.HelpedStudent.Add(newHelpedStudent3);
            appContext.HelpedStudent.Add(newHelpedStudent4);
            appContext.HelpedStudent.Add(newHelpedStudent5);
            appContext.HelpedStudent.Add(newHelpedStudent6);
            appContext.HelpedStudent.Add(newHelpedStudent7);
            appContext.HelpedStudent.Add(newHelpedStudent8);
            appContext.HelpedStudent.Add(newHelpedStudent9);
            appContext.HelpedStudent.Add(newHelpedStudent10);
            appContext.HelpedStudent.Add(newHelpedStudent11);

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

            appContext.TutoringSession.Add(newTutoringSession1);
            appContext.TutoringSession.Add(newTutoringSession2);
            appContext.TutoringSession.Add(newTutoringSession3);
            appContext.TutoringSession.Add(newTutoringSession4);
            appContext.TutoringSession.Add(newTutoringSession5);
            appContext.TutoringSession.Add(newTutoringSession6);
            appContext.TutoringSession.Add(newTutoringSession7);
            appContext.TutoringSession.Add(newTutoringSession8);
            appContext.TutoringSession.Add(newTutoringSession9);
            appContext.TutoringSession.Add(newTutoringSession10);
            appContext.TutoringSession.Add(newTutoringSession11);
            appContext.TutoringSession.Add(newTutoringSession12);
            appContext.TutoringSession.Add(newTutoringSession13);
            appContext.TutoringSession.Add(newTutoringSession14);
            appContext.TutoringSession.Add(newTutoringSession15);
            appContext.TutoringSession.Add(newTutoringSession16);
            appContext.TutoringSession.Add(newTutoringSession17);
            appContext.TutoringSession.Add(newTutoringSession18);
            base.Seed(appContext);
        }
    }
    public class SinapseRepository<T> : IEntityRepository<T> where T : Entity
        {
        private/protected readonly DbContext context;
        public EfEntityRepository(DbContext sinapseContext)
        {
        context = sinapseContext;
        }


        }
