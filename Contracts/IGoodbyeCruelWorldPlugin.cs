using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.Composition;

namespace Contracts
{
	[InheritedExport]
	public interface IGoodbyeCruelWorldPlugin
	{
		string GetGoodbyeMessage();
	}
}
