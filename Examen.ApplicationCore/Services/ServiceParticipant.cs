using Examen.ApplicationCore.Domain;
using Examen.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Services
{
    public class ServiceParticipant : Service<Participant>, IServiceParticipant
    {

        public ServiceParticipant(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public List<Specialite> specialitesSeminaires(DateTime dateSem)
        {
            //var participants = GetAll().Where(i => i.Seminaire.dateSeminaire == dateSem)
            //    .Select(i => i.Participant).ToList();
            //participants.Select(p => )
             
            //var participants = GetAll().
            //    OfType<Universitaire>().
            //    Where(p=>p.Inscriptions.SelectMany<Seminaire>(i=>i.Seminaire.dateSeminaire == dateSem)).
            //    Select(p => p.)
            //    ToList();
            return null; 
        }

    }
}
