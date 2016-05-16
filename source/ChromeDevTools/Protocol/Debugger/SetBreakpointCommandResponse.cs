using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Sets JavaScript breakpoint at a given location.
	/// </summary>
	[CommandResponse(ProtocolName.Debugger.SetBreakpoint)]
	[SupportedBy("Chrome-Tip")]
	public class SetBreakpointCommandResponse
	{
		/// <summary>
		/// Gets or sets Id of the created breakpoint for further reference.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		[SupportedBy("iOS-9.3")]
		public string BreakpointId { get; set; }
		/// <summary>
		/// Gets or sets Location this breakpoint resolved into.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		[SupportedBy("iOS-9.3")]
		public Location ActualLocation { get; set; }
	}
}
