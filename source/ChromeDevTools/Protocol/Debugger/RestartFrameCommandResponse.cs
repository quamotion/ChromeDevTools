using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Restarts particular call frame from the beginning.
	/// </summary>
	[CommandResponse(ProtocolName.Debugger.RestartFrame)]
	[SupportedBy("Chrome-Tip")]
	public class RestartFrameCommandResponse
	{
		/// <summary>
		/// Gets or sets New stack trace.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public CallFrame[] CallFrames { get; set; }
		/// <summary>
		/// Gets or sets VM-specific description.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public object Result { get; set; }
		/// <summary>
		/// Gets or sets Async stack trace, if any.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public StackTrace AsyncStackTrace { get; set; }
	}
}
