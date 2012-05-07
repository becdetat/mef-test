using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Consumer
{
	public class SafePluginComposer
	{
		AppDomain _pluginAppDomain;
		PluginComposer _composer;

		public SafePluginComposer()
		{
			_pluginAppDomain = AppDomain.CreateDomain(
				"ConsumerPlugins_" + Guid.NewGuid().ToString(),
				new System.Security.Policy.Evidence(AppDomain.CurrentDomain.Evidence),
				AppDomain.CurrentDomain.BaseDirectory,
				AppDomain.CurrentDomain.BaseDirectory,
				true);
			_composer = (PluginComposer)_pluginAppDomain.CreateInstanceAndUnwrap(
				typeof(PluginComposer).Assembly.GetName().FullName,
				typeof(PluginComposer).FullName);
		}

		public void Compose(object o)
		{
			_composer.Compose(o);
		}
	}
}
