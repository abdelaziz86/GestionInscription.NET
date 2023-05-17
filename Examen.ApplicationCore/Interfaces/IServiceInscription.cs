using Examen.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Interfaces
{
    public interface IServiceInscription : IService<Inscription>
    {
        public List<Participant> participantsSeminaires(Seminaire seminaire );

        public double tauxUniversitaires(int annee);

        public List<Specialite> specialitesSeminaires(DateTime dateSem);

    }
}
