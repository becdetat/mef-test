using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Contracts;

namespace Consumer
{
	[Serializable]
	public class LocalHelloWorldPlugin : IHelloWorldPlugin
	{
		public string GetHelloMessage()
		{
			return "Local hello, AppDomain: " + AppDomain.CurrentDomain.FriendlyName;
		}
	}
}
