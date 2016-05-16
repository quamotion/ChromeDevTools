using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.DOMDebugger
{
	/// <summary>
	/// Sets breakpoint on particular native event.
	/// </summary>
	[Command(ProtocolName.DOMDebugger.SetInstrumentationBreakpoint)]
	[SupportedBy("Chrome-Tip")]
	public class SetInstrumentationBreakpointCommand
	{
		/// <summary>
		/// Gets or sets Instrumentation name to stop on.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string EventName { get; set; }
	}
}
