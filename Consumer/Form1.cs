using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Contracts;

namespace Consumer
{
	public partial class Form1 : Form
	{
		IGetName _getName;
		IEnumerable<IHelloWorldPlugin> _helloWorldPlugins;
		IEnumerable<IGoodbyeCruelWorldPlugin> _goodbyeCruelWorldPlugins;

		public Form1()
		{
			InitializeComponent();
		}

		private void GetNameTextBox_TextChanged(object sender, EventArgs e)
		{
			((GetName)_getName).Name = GetNameTextBox.Text;
		}

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
