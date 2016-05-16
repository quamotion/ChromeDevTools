using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.DOMDebugger
{
	/// <summary>
	/// Sets breakpoint on particular operation with DOM.
	/// </summary>
	[Command(ProtocolName.DOMDebugger.SetDOMBreakpoint)]
	[SupportedBy("Chrome-Tip")]
	[SupportedBy("iOS-9.3")]
	public class SetDOMBreakpointCommand
	{
		/// <summary>
		/// Gets or sets Identifier of the node to set breakpoint on.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		[SupportedBy("iOS-9.3")]
		public long NodeId { get; set; }
		/// <summary>
		/// Gets or sets Type of the operation to stop upon.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		[SupportedBy("iOS-9.3")]
		public string Type { get; set; }
	}
}
