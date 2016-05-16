using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Enables promise tracking, information about <code>Promise</code>s created or updated will now be stored on the backend.
	/// </summary>
	[Command(ProtocolName.Debugger.EnablePromiseTracker)]
	[SupportedBy("Chrome-Tip")]
	public class EnablePromiseTrackerCommand
	{
		/// <summary>
		/// Gets or sets Whether to capture stack traces for promise creation and settlement events (default: false).
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public bool CaptureStacks { get; set; }
	}
}
