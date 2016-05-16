using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.DOMDebugger
{
	/// <summary>
	/// Removes breakpoint from XMLHttpRequest.
	/// </summary>
	[Command(ProtocolName.DOMDebugger.RemoveXHRBreakpoint)]
	[SupportedBy("Chrome-Tip")]
	public class RemoveXHRBreakpointCommand
	{
		/// <summary>
		/// Gets or sets Resource URL substring.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Url { get; set; }
	}
}
