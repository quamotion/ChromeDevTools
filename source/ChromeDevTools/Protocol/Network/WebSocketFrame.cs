using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Network
{
	/// <summary>
	/// WebSocket frame data.
	/// </summary>
	[SupportedBy("Chrome-Tip")]
	public class WebSocketFrame
	{
		/// <summary>
		/// Gets or sets WebSocket frame opcode.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public double Opcode { get; set; }
		/// <summary>
		/// Gets or sets WebSocke frame mask.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public bool Mask { get; set; }
		/// <summary>
		/// Gets or sets WebSocke frame payload data.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string PayloadData { get; set; }
	}
}
