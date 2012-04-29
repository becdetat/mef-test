using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Contracts;

namespace Consumer
{
	class GetName : IGetName
	{
		public string Name { get; internal set; }
	}
}
