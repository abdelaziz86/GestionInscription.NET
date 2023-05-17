using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public class Specialite
    {
        public int specialiteId { get; set; }
        public string nom { get; set; }
        public string abreviation { get; set; }


            
        public virtual IList<Universitaire> Universitaires { get; set; }

    }
}
