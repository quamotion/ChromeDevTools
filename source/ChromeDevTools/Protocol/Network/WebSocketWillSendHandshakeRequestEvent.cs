using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.Network
{
	/// <summary>
	/// Fired when WebSocket is about to initiate handshake.
	/// </summary>
	[Event(ProtocolName.Network.WebSocketWillSendHandshakeRequest)]
	[SupportedBy("Chrome-Tip")]
	public class WebSocketWillSendHandshakeRequestEvent
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
		/// Gets or sets UTC Timestamp.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public double WallTime { get; set; }
		/// <summary>
		/// Gets or sets WebSocket request data.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public WebSocketRequest Request { get; set; }
	}
}
