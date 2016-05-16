using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.Network
{
	/// <summary>
	/// Fired when page is about to send HTTP request.
	/// </summary>
	[Event(ProtocolName.Network.RequestWillBeSent)]
	[SupportedBy("Chrome-Tip")]
	public class RequestWillBeSentEvent
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
		/// Gets or sets URL of the document this request is loaded for.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string DocumentURL { get; set; }
		/// <summary>
		/// Gets or sets Request data.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public Request Request { get; set; }
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
		/// Gets or sets Request initiator.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public Initiator Initiator { get; set; }
		/// <summary>
		/// Gets or sets Redirect response data.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public Response RedirectResponse { get; set; }
		/// <summary>
		/// Gets or sets Type of this resource.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public Page.ResourceType Type { get; set; }
	}
}
