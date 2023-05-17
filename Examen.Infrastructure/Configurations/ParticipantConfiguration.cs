using Examen.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Infrastructure.Configurations
{
    public class ParticipantConfiguration : IEntityTypeConfiguration<Participant>
    {
        public void Configure(EntityTypeBuilder<Participant> builder)
        {

            builder
                .HasDiscriminator<char>("TypeParticipant")
                .HasValue<Participant>('P')
                .HasValue<Universitaire>('U')
                .HasValue<Industriel>('I');
        }
    }
}
