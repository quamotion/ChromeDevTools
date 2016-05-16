using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.DOMDebugger
{
	/// <summary>
	/// Removes breakpoint on particular DOM event.
	/// </summary>
	[Command(ProtocolName.DOMDebugger.RemoveEventListenerBreakpoint)]
	[SupportedBy("Chrome-Tip")]
	public class RemoveEventListenerBreakpointCommand
	{
		/// <summary>
		/// Gets or sets Event name.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		[SupportedBy("iOS-9.3")]
		public string EventName { get; set; }
		/// <summary>
		/// Gets or sets EventTarget interface name.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string TargetName { get; set; }
	}
}
