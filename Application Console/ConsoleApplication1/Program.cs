
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ConsoleApplication1.Model;
using ConsoleApplication1.Context;
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
            Application app = new Application(context);
            init.InitializeDatabase(context);
            app.Seed();
            app.SectionA();
            app.SectionB(); // N'a pas été bien fait dans remise 2 donc contenu effacé pour remise 3
            app.SectionC(context);
        }
    }



}
