using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;

namespace Consumer
{
	public class PluginComposer : MarshalByRefObject
	{
		CompositionContainer _container;

		public PluginComposer()
		{
			var catalog = new AggregateCatalog();
			catalog.Catalogs.Add(new AssemblyCatalog(System.Reflection.Assembly.GetExecutingAssembly()));
			catalog.Catalogs.Add(new AssemblyCatalog("Plugins.dll"));

			_container = new CompositionContainer(catalog);
		}

		public void Compose(object o)
		{
			_container.ComposeParts(o);
		}
	}
}
