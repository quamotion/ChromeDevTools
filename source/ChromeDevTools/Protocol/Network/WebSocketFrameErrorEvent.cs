using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.Network
{
	/// <summary>
	/// Fired when WebSocket frame error occurs.
	/// </summary>
	[Event(ProtocolName.Network.WebSocketFrameError)]
	[SupportedBy("Chrome-Tip")]
	public class WebSocketFrameErrorEvent
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
		/// Gets or sets WebSocket frame error message.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string ErrorMessage { get; set; }
	}
}
