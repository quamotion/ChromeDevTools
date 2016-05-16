using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Restarts particular call frame from the beginning.
	/// </summary>
	[Command(ProtocolName.Debugger.RestartFrame)]
	[SupportedBy("Chrome-Tip")]
	public class RestartFrameCommand
	{
		/// <summary>
		/// Gets or sets Call frame identifier to evaluate on.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string CallFrameId { get; set; }
	}
}
