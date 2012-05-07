using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Windows.Forms;
using Contracts;

namespace Consumer
{
	public partial class Form1 : Form, IGetName
	{
		[ImportMany]
		public IEnumerable<IHelloWorldPlugin> HelloWorldPlugins { get; private set; }
		[ImportMany]
		public IEnumerable<IGoodbyeCruelWorldPlugin> GoodbyeCruelWorldPlugins { get; private set; }

		public Form1()
		{
			InitializeComponent();

			var pluginComposer = new SafePluginComposer();
			pluginComposer.Compose(this);
		}

		public string GetName() { return GetNameTextBox.Text; }

		private void HelloWorld_Click(object sender, EventArgs e)
		{
			foreach (var plugin in HelloWorldPlugins)
			{
				MessageBox.Show(plugin.GetHelloMessage());
			}
		}

		private void GoodbyeCruelWorld_Click(object sender, EventArgs e)
		{
			foreach (var plugin in GoodbyeCruelWorldPlugins)
			{
				MessageBox.Show(plugin.GetGoodbyeMessage());
			}
		}
	}
}
