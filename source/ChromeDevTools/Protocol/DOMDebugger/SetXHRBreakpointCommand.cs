using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.DOMDebugger
{
	/// <summary>
	/// Sets breakpoint on XMLHttpRequest.
	/// </summary>
	[Command(ProtocolName.DOMDebugger.SetXHRBreakpoint)]
	[SupportedBy("Chrome-Tip")]
	[SupportedBy("iOS-9.3")]
	public class SetXHRBreakpointCommand
	{
		/// <summary>
		/// Gets or sets Resource URL substring. All XHRs having this substring in the URL will get stopped upon.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		[SupportedBy("iOS-9.3")]
		public string Url { get; set; }
	}
}
