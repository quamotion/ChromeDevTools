using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Sets JavaScript breakpoint at a given location.
	/// </summary>
	[Command(ProtocolName.Debugger.SetBreakpoint)]
	[SupportedBy("Chrome-Tip")]
	public class SetBreakpointCommand
	{
		/// <summary>
		/// Gets or sets Location to set breakpoint in.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		[SupportedBy("iOS-9.3")]
		public Location Location { get; set; }
		/// <summary>
		/// Gets or sets Expression to use as a breakpoint condition. When specified, debugger will only stop on the breakpoint if this expression evaluates to true.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Condition { get; set; }
		/// <summary>
		/// Gets or sets Options to apply to this breakpoint to modify its behavior.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public BreakpointOptions Options { get; set; }
	}
}
