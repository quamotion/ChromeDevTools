using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Removes JavaScript breakpoint.
	/// </summary>
	[Command(ProtocolName.Debugger.RemoveBreakpoint)]
	[SupportedBy("Chrome-Tip")]
	public class RemoveBreakpointCommand
	{
		/// <summary>
		/// Gets or sets BreakpointId
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string BreakpointId { get; set; }
	}
}
