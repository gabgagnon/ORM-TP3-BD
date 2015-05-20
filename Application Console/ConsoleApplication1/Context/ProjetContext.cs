using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ConsoleApplication1.Model;

namespace ConsoleApplication1.Context
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

        }
    }
}
