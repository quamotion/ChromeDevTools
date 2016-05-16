using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Removes AsyncOperation breakpoint.
	/// </summary>
	[Command(ProtocolName.Debugger.RemoveAsyncOperationBreakpoint)]
	[SupportedBy("Chrome-Tip")]
	public class RemoveAsyncOperationBreakpointCommand
	{
		/// <summary>
		/// Gets or sets ID of the async operation to remove breakpoint for.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long OperationId { get; set; }
	}
}
