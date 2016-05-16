using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.DOMDebugger
{
	/// <summary>
	/// Sets breakpoint on particular DOM event.
	/// </summary>
	[Command(ProtocolName.DOMDebugger.SetEventListenerBreakpoint)]
	[SupportedBy("Chrome-Tip")]
	public class SetEventListenerBreakpointCommand
	{
		/// <summary>
		/// Gets or sets DOM Event name to stop on (any DOM event will do).
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string EventName { get; set; }
		/// <summary>
		/// Gets or sets EventTarget interface name to stop on. If equal to <code>"*"</code> or not provided, will stop on any EventTarget.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string TargetName { get; set; }
	}
}
