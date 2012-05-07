using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Contracts;
using System.ComponentModel.Composition;

namespace Plugins
{
	public class HelloNamePlugin : MarshalByRefObject, IHelloWorldPlugin
	{
		readonly IGetName _getName;

		[ImportingConstructor]
		public HelloNamePlugin(IGetName getName)
		{
			_getName = getName;
		}

		public string GetHelloMessage() { return string.Format("Hello, {0}!", _getName.GetName()); }
	}
}
