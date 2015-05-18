using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace ConsoleApplication1.Model
{
    public class Tutor : Entity
    {

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string EmailAddress { get; set; }

        public virtual ICollection<TutoringSession> TutoringSessionList { get; set; }
    }
}
