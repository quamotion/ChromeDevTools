using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.Network
{
	/// <summary>
	/// Fired when WebSocket frame is sent.
	/// </summary>
	[Event(ProtocolName.Network.WebSocketFrameSent)]
	[SupportedBy("Chrome-Tip")]
	public class WebSocketFrameSentEvent
	{
		/// <summary>
		/// Gets or sets Request identifier.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string RequestId { get; set; }
		/// <summary>
		/// Gets or sets Timestamp.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public double Timestamp { get; set; }
		/// <summary>
		/// Gets or sets WebSocket response data.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public WebSocketFrame Response { get; set; }
	}
}
