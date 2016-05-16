using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Canvas
{
	[CommandResponse(ProtocolName.Canvas.ReplayTraceLog)]
	[SupportedBy("Chrome-Tip")]
	public class ReplayTraceLogCommandResponse
	{
		/// <summary>
		/// Gets or sets ResourceState
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public ResourceState ResourceState { get; set; }
		/// <summary>
		/// Gets or sets Replay time (in milliseconds).
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public double ReplayTime { get; set; }
	}
}
