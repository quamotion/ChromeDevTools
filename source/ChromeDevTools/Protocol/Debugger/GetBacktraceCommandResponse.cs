using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Returns call stack including variables changed since VM was paused. VM must be paused.
	/// </summary>
	[CommandResponse(ProtocolName.Debugger.GetBacktrace)]
	[SupportedBy("Chrome-Tip")]
	public class GetBacktraceCommandResponse
	{
		/// <summary>
		/// Gets or sets Call stack the virtual machine stopped on.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public CallFrame[] CallFrames { get; set; }
		/// <summary>
		/// Gets or sets Async stack trace, if any.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public StackTrace AsyncStackTrace { get; set; }
	}
}
