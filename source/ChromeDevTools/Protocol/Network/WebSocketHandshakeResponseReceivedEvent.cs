using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.Network
{
	/// <summary>
	/// Fired when WebSocket handshake response becomes available.
	/// </summary>
	[Event(ProtocolName.Network.WebSocketHandshakeResponseReceived)]
	[SupportedBy("Chrome-Tip")]
	public class WebSocketHandshakeResponseReceivedEvent
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
		public WebSocketResponse Response { get; set; }
	}
}
