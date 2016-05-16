using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Canvas
{
	[Command(ProtocolName.Canvas.DropTraceLog)]
	[SupportedBy("Chrome-Tip")]
	public class DropTraceLogCommand
	{
		/// <summary>
		/// Gets or sets TraceLogId
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string TraceLogId { get; set; }
	}
}
