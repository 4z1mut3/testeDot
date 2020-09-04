using System.Data.Entity.ModelConfiguration;

namespace Prova
{
    public class TiposSegurosConfigurations : EntityTypeConfiguration<TiposSeguros>
    {
        public TiposSegurosConfigurations()
        {
            Property(s => s.DS_TIPOSEGURO)
                .IsRequired()
                .HasMaxLength(400);

            Property(s => s.CARENCIA)
                .IsRequired();

            Property(s => s.IDTIPOSEGURO)
                .IsRequired();

            HasKey(s => s.IDTIPOSEGURO);
        }
    }
}