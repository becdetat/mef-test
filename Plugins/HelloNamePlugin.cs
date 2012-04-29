using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Contracts;

namespace Plugins
{
	public class HelloNamePlugin : IHelloWorldPlugin
	{
		IGetName _getName;
		public string GetHelloMessage() { return string.Format("Hello, {0}!", _getName.Name); }
	}
}
