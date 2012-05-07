using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Contracts;

namespace Plugins
{
	[Serializable]
	public class GoodbyeCruelWorldPlugin : MarshalByRefObject, IGoodbyeCruelWorldPlugin
	{
		public string GetGoodbyeMessage() { return "Noooooooo!!!!"; }
	}
}
