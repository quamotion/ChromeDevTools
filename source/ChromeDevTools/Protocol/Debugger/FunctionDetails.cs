using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Information about the function.
	/// </summary>
	[SupportedBy("Chrome-Tip")]
	public class FunctionDetails
	{
		/// <summary>
		/// Gets or sets Location of the function, none for native functions.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public Location Location { get; set; }
		/// <summary>
		/// Gets or sets Name of the function.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string FunctionName { get; set; }
		/// <summary>
		/// Gets or sets Whether this is a generator function.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public bool IsGenerator { get; set; }
		/// <summary>
		/// Gets or sets Scope chain for this closure.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public Scope[] ScopeChain { get; set; }
	}
}
