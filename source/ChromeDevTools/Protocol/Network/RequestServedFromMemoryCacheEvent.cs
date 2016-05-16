using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.Network
{
	/// <summary>
	/// Fired when HTTP request has been served from memory cache.
	/// </summary>
	[Event(ProtocolName.Network.RequestServedFromMemoryCache)]
	[SupportedBy("iOS-9.3")]
	public class RequestServedFromMemoryCacheEvent
	{
		/// <summary>
		/// Gets or sets Request identifier.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public string RequestId { get; set; }
		/// <summary>
		/// Gets or sets Frame identifier.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public string FrameId { get; set; }
		/// <summary>
		/// Gets or sets Loader identifier.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public string LoaderId { get; set; }
		/// <summary>
		/// Gets or sets URL of the document this request is loaded for.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public string DocumentURL { get; set; }
		/// <summary>
		/// Gets or sets Timestamp.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public double Timestamp { get; set; }
		/// <summary>
		/// Gets or sets Request initiator.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public Initiator Initiator { get; set; }
		/// <summary>
		/// Gets or sets Cached resource data.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public CachedResource Resource { get; set; }
	}
}
