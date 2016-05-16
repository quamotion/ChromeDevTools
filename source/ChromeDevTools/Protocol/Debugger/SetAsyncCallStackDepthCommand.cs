using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Enables or disables async call stacks tracking.
	/// </summary>
	[Command(ProtocolName.Debugger.SetAsyncCallStackDepth)]
	[SupportedBy("Chrome-Tip")]
	public class SetAsyncCallStackDepthCommand
	{
		/// <summary>
		/// Gets or sets Maximum depth of async call stacks. Setting to <code>0</code> will effectively disable collecting async call stacks (default).
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long MaxDepth { get; set; }
	}
}
