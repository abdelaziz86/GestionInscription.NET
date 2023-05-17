using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examen.ApplicationCore.Domain;

namespace Examen.Infrastructure.Configurations
{
    public class InscriptionConfiguration : IEntityTypeConfiguration<Inscription>
    {
        public void Configure(EntityTypeBuilder<Inscription> builder)
        {
            builder.HasKey(e => new { e.ParticipantFK, e.SeminiareFK, e.dateInscription });

            builder.HasOne(e => e.Participant).WithMany(e => e.Inscriptions).HasForeignKey(e => e.ParticipantFK);
            builder.HasOne(e => e.Seminaire).WithMany(e => e.Inscriptions).HasForeignKey(e => e.SeminiareFK);
        }
            
    }
}
