using System.Data.Entity;

namespace Prova
{
    public class ProvaContext : DbContext
    {
        public ProvaContext() : base("BancoProva")
        {
            Database.SetInitializer(new ProvaDBInitializer());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new TiposSegurosConfigurations());
        }

        public DbSet<TiposSeguros> TiposSeguros { get; set; }
    }
}