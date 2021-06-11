using Chronus.DXperience;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.IO;
using System.Reflection;

namespace VIPER.WFA
{
    public class MEF
    {
        [ImportMany(AllowRecomposition = true)]
        public IEnumerable<IFormulario> Formularios { get; set; }

        public void CarregarAssembly()
        {
            using (var dcatalog = new DirectoryCatalog(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "VIPER.*.dll"))
            {
                using (var acatalog = new AssemblyCatalog(Assembly.GetExecutingAssembly()))
                {
                    using (var catalog = new AggregateCatalog(dcatalog, acatalog))
                    {
                        using (var container = new CompositionContainer(catalog))
                        {
                            container.ComposeParts(this);
                        }
                    }
                }
            }
        }
    }
}
