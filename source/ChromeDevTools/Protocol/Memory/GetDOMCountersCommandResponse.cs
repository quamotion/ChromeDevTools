using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Memory
{
	[CommandResponse(ProtocolName.Memory.GetDOMCounters)]
	[SupportedBy("Chrome-Tip")]
	public class GetDOMCountersCommandResponse
	{
		/// <summary>
		/// Gets or sets Documents
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long Documents { get; set; }
		/// <summary>
		/// Gets or sets Nodes
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long Nodes { get; set; }
		/// <summary>
		/// Gets or sets JsEventListeners
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long JsEventListeners { get; set; }
	}
}
