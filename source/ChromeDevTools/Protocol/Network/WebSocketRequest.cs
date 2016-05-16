using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Network
{
	/// <summary>
	/// WebSocket request data.
	/// </summary>
	[SupportedBy("Chrome-Tip")]
	public class WebSocketRequest
	{
		/// <summary>
		/// Gets or sets HTTP request headers.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public Dictionary<string, string> Headers { get; set; }
	}
}
