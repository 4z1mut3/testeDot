using System.Collections.Generic;
using System.Data.Entity;

namespace Prova
{
    public class ProvaDBInitializer : DropCreateDatabaseIfModelChanges<ProvaContext>
    {
        protected override void Seed(ProvaContext context)
        {
            IList<TiposSeguros> tiposSeguros = new List<TiposSeguros>();

            tiposSeguros.Add(new TiposSeguros() { DS_TIPOSEGURO = "CONSIGNADO", CARENCIA = 30 });
            tiposSeguros.Add(new TiposSeguros() { DS_TIPOSEGURO = "ACIDENTES PESSOAIS", CARENCIA = 0 });
            tiposSeguros.Add(new TiposSeguros() { DS_TIPOSEGURO = "VIDA SIMPLES", CARENCIA = 30 });

            context.TiposSeguros.AddRange(tiposSeguros);

            base.Seed(context);
        }
    }
}