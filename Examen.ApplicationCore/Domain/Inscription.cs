using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public class Inscription
    {
        public DateTime dateInscription { get; set; }
        public double tauxReduction { get; set; }



        public int SeminiareFK { get; set; }
        public virtual Seminaire Seminaire { get; set; }

        public int ParticipantFK { get; set; }
        public virtual Participant Participant { get; set; }
    }
}
