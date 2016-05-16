using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.Network
{
	/// <summary>
	/// Fired when WebSocket frame is received.
	/// </summary>
	[Event(ProtocolName.Network.WebSocketFrameReceived)]
	[SupportedBy("Chrome-Tip")]
	public class WebSocketFrameReceivedEvent
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
