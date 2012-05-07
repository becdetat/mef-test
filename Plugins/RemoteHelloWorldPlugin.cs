using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Contracts;
using System.ComponentModel.Composition;

namespace Plugins
{
	public class RemoteHelloWorldPlugin : MarshalByRefObject, IHelloWorldPlugin
	{
		public string GetHelloMessage() { return "Hello, AppDomain: " + AppDomain.CurrentDomain.FriendlyName; }
	}
}
