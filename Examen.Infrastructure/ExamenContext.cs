
using Examen.ApplicationCore.Domain;
using Examen.Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;

namespace Examen.Infrastructure
{
    public class ExamenContext: DbContext
    {
        public DbSet<Participant> Participants { get; set; }
        public DbSet<Industriel> Industriels { get; set; }
        public DbSet<Seminaire> Seminaires { get; set; }
        public DbSet<Universitaire> Universitaires { get; set; }
        public DbSet<Specialite> Specialites { get; set; }
        public DbSet<Inscription> Inscriptions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=examInscription;Integrated Security=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new InscriptionConfiguration());
            modelBuilder.ApplyConfiguration(new ParticipantConfiguration());

        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<string>().HaveMaxLength(100).HaveColumnType("varchar");

        }

    }
}