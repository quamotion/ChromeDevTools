using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Information about the generator object.
	/// </summary>
	[SupportedBy("Chrome-Tip")]
	public class GeneratorObjectDetails
	{
		/// <summary>
		/// Gets or sets Generator function.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public Runtime.RemoteObject Function { get; set; }
		/// <summary>
		/// Gets or sets Name of the generator function.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string FunctionName { get; set; }
		/// <summary>
		/// Gets or sets Current generator object status.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Status { get; set; }
		/// <summary>
		/// Gets or sets If suspended, location where generator function was suspended (e.g. location of the last 'yield'). Otherwise, location of the generator function.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public Location Location { get; set; }
	}
}
