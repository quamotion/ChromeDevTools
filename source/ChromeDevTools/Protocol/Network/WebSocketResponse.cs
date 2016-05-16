using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Network
{
	/// <summary>
	/// WebSocket response data.
	/// </summary>
	[SupportedBy("Chrome-Tip")]
	public class WebSocketResponse
	{
		/// <summary>
		/// Gets or sets HTTP response status code.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public double Status { get; set; }
		/// <summary>
		/// Gets or sets HTTP response status text.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string StatusText { get; set; }
		/// <summary>
		/// Gets or sets HTTP response headers.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public Dictionary<string, string> Headers { get; set; }
		/// <summary>
		/// Gets or sets HTTP response headers text.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string HeadersText { get; set; }
		/// <summary>
		/// Gets or sets HTTP request headers.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public Dictionary<string, string> RequestHeaders { get; set; }
		/// <summary>
		/// Gets or sets HTTP request headers text.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string RequestHeadersText { get; set; }
	}
}
