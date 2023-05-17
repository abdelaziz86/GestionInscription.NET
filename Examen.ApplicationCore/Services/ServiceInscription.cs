using Examen.ApplicationCore.Domain;
using Examen.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Services
{
    public class ServiceInscription : Service<Inscription>, IServiceInscription
    {

        public ServiceInscription(IUnitOfWork unitOfWork) : base(unitOfWork)
        { 
        }

        public List<Participant> participantsSeminaires(Seminaire seminaire)
        {
            return GetAll().Where(i=>i.Seminaire== seminaire).Select(i=>i.Participant).ToList();
        }


        public double tauxUniversitaires(int annee)
        {
            var universitaires = GetAll().Where(i=>i.Seminaire.dateSeminaire.Year == annee)
                .Select(i=>i.Participant).OfType<Universitaire>().ToList().Count();
            var all = GetAll().Where(i => i.Seminaire.dateSeminaire.Year == annee)
                .Select(i => i.Participant).ToList().Count();
            return (universitaires / all) * 100; 
        }


        public List<Specialite> specialitesSeminaires(DateTime dateSem)
        {
            var participants = GetAll().Where(i => i.Seminaire.dateSeminaire == dateSem)
                .Select(i => i.Participant).OfType<Universitaire>();
            var Specialites = participants.Select(p => p.Specialite);
            return Specialites.ToList(); 
             
        }






    }
}
