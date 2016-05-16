using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.Network
{
	/// <summary>
	/// Fired when WebSocket is closed.
	/// </summary>
	[Event(ProtocolName.Network.WebSocketClosed)]
	[SupportedBy("Chrome-Tip")]
	public class WebSocketClosedEvent
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
	}
}
