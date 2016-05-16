using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Action to perform when a breakpoint is triggered.
	/// </summary>
	[SupportedBy("iOS-9.3")]
	public class BreakpointAction
	{
		/// <summary>
		/// Gets or sets Different kinds of breakpoint actions.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public string Type { get; set; }
		/// <summary>
		/// Gets or sets Data associated with this breakpoint type (e.g. for type "eval" this is the JavaScript string to evalulate).
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public string Data { get; set; }
		/// <summary>
		/// Gets or sets A frontend-assigned identifier for this breakpoint action.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public long Id { get; set; }
	}
}
