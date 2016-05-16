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
		[SupportedBy("iOS-9.3")]
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
		[SupportedBy("iOS-9.3")]
		public Scope[] ScopeChain { get; set; }
		/// <summary>
		/// Gets or sets Name of the function. Not present for anonymous functions.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public string Name { get; set; }
		/// <summary>
		/// Gets or sets Display name of the function(specified in 'displayName' property on the function object).
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public string DisplayName { get; set; }
		/// <summary>
		/// Gets or sets Name of the function inferred from its initial assignment.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public string InferredName { get; set; }
	}
}
