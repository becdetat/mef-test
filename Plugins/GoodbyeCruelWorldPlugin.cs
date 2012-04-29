using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Contracts;

namespace Plugins
{
	public class GoodbyeCruelWorldPlugin : IGoodbyeCruelWorldPlugin
	{
		public string GetGoodbyeMessage() { return "Noooooooo!!!!"; }
	}
}
