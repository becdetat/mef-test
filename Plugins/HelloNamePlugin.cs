using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Contracts;
using System.ComponentModel.Composition;

namespace Plugins
{
	public class HelloNamePlugin : IHelloWorldPlugin
	{
		[Import]
		IGetName _getName;
		public string GetHelloMessage() { return string.Format("Hello, {0}!", _getName.GetName()); }
	}
}
