using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Canvas
{
	[Command(ProtocolName.Canvas.GetTraceLog)]
	[SupportedBy("Chrome-Tip")]
	public class GetTraceLogCommand
	{
		/// <summary>
		/// Gets or sets TraceLogId
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string TraceLogId { get; set; }
		/// <summary>
		/// Gets or sets StartOffset
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long StartOffset { get; set; }
		/// <summary>
		/// Gets or sets MaxLength
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long MaxLength { get; set; }
	}
}
