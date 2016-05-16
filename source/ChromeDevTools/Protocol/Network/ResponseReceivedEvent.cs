using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.Network
{
	/// <summary>
	/// Fired when HTTP response is available.
	/// </summary>
	[Event(ProtocolName.Network.ResponseReceived)]
	[SupportedBy("Chrome-Tip")]
	public class ResponseReceivedEvent
	{
		/// <summary>
		/// Gets or sets Request identifier.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string RequestId { get; set; }
		/// <summary>
		/// Gets or sets Frame identifier.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string FrameId { get; set; }
		/// <summary>
		/// Gets or sets Loader identifier.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string LoaderId { get; set; }
		/// <summary>
		/// Gets or sets Timestamp.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public double Timestamp { get; set; }
		/// <summary>
		/// Gets or sets Resource type.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public Page.ResourceType Type { get; set; }
		/// <summary>
		/// Gets or sets Response data.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public Response Response { get; set; }
	}
}
