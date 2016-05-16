using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Canvas
{
	[CommandResponse(ProtocolName.Canvas.GetTraceLog)]
	[SupportedBy("Chrome-Tip")]
	public class GetTraceLogCommandResponse
	{
		/// <summary>
		/// Gets or sets TraceLog
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public TraceLog TraceLog { get; set; }
	}
}
