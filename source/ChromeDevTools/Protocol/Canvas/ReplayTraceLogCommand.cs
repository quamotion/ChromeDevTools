using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Canvas
{
	[Command(ProtocolName.Canvas.ReplayTraceLog)]
	[SupportedBy("Chrome-Tip")]
	public class ReplayTraceLogCommand
	{
		/// <summary>
		/// Gets or sets TraceLogId
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string TraceLogId { get; set; }
		/// <summary>
		/// Gets or sets Last call index in the trace log to replay (zero based).
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long StepNo { get; set; }
	}
}
