using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.Network
{
	/// <summary>
	/// Fired when EventSource message is received.
	/// </summary>
	[Event(ProtocolName.Network.EventSourceMessageReceived)]
	[SupportedBy("Chrome-Tip")]
	public class EventSourceMessageReceivedEvent
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
		/// Gets or sets Message type.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string EventName { get; set; }
		/// <summary>
		/// Gets or sets Message identifier.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string EventId { get; set; }
		/// <summary>
		/// Gets or sets Message content.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Data { get; set; }
	}
}
