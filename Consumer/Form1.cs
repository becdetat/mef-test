using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Contracts;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;

namespace Consumer
{
	public partial class Form1 : Form, IGetName
	{
		[ImportMany]
		IEnumerable<IHelloWorldPlugin> _helloWorldPlugins;
		[ImportMany]
		IEnumerable<IGoodbyeCruelWorldPlugin> _goodbyeCruelWorldPlugins;

		public Form1()
		{
			InitializeComponent();

			var catalog = new AggregateCatalog();
			catalog.Catalogs.Add(new AssemblyCatalog(System.Reflection.Assembly.GetExecutingAssembly()));
			catalog.Catalogs.Add(new AssemblyCatalog("Plugins.dll"));
			var container = new CompositionContainer(catalog);
			container.ComposeParts(this);
		}

		public string GetName() { return GetNameTextBox.Text; }

		private void HelloWorld_Click(object sender, EventArgs e)
		{
			foreach (var plugin in _helloWorldPlugins)
			{
				MessageBox.Show(plugin.GetHelloMessage());
			}
		}

		private void GoodbyeCruelWorld_Click(object sender, EventArgs e)
		{
			foreach (var plugin in _goodbyeCruelWorldPlugins)
			{
				MessageBox.Show(plugin.GetGoodbyeMessage());
			}
		}
	}
}
