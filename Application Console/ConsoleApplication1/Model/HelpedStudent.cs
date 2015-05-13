using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace ConsoleApplication1.Model
{
    public class HelpedStudent
    {
        public int Id { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string EmailAddress { get; set; }

        public virtual ICollection<TutoringSession> TutoringSessionList { get; set; } // collection qui contient des affectations 
        //virtual vient nous dire que cela vient d'une autre classe, virtual n'est pas propre à cette classe la
        //virtual nous dit que cela fais le lien avec une autre classe

    }
}
