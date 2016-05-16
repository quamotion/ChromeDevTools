using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Edits JavaScript source live.
	/// </summary>
	[CommandResponse(ProtocolName.Debugger.SetScriptSource)]
	[SupportedBy("Chrome-Tip")]
	public class SetScriptSourceCommandResponse
	{
		/// <summary>
		/// Gets or sets New stack trace in case editing has happened while VM was stopped.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public CallFrame[] CallFrames { get; set; }
		/// <summary>
		/// Gets or sets VM-specific description of the changes applied.
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
