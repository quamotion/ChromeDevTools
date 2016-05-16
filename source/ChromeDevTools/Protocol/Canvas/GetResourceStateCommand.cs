using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Canvas
{
	[Command(ProtocolName.Canvas.GetResourceState)]
	[SupportedBy("Chrome-Tip")]
	public class GetResourceStateCommand
	{
		/// <summary>
		/// Gets or sets TraceLogId
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string TraceLogId { get; set; }
		/// <summary>
		/// Gets or sets ResourceId
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string ResourceId { get; set; }
	}
}
