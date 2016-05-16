using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Sets breakpoint on AsyncOperation callback handler.
	/// </summary>
	[Command(ProtocolName.Debugger.SetAsyncOperationBreakpoint)]
	[SupportedBy("Chrome-Tip")]
	public class SetAsyncOperationBreakpointCommand
	{
		/// <summary>
		/// Gets or sets ID of the async operation to set breakpoint for.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long OperationId { get; set; }
	}
}
