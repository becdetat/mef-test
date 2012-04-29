using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Contracts;

namespace Plugins
{
	public class BasicHelloWorldPlugin : IHelloWorldPlugin
	{
		public string GetHelloMessage() { return "Hello, world!"; }
	}


}
