using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ConsoleApplication1.Model
{
    public class TutoringSession
    {
        [Key]
        public int Id { get; set; }

        public int TutorId { get; set; }
        public virtual Tutor Tutor { get; set; }

        public int HelpedId { get; set; }
        public virtual HelpedStudent Helped { get; set; }

        public DateTime DateSession { get; set; }

        public int TimeSession { get; set; }

        public int LengthSession { get; set; }
    }
}

