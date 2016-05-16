using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.ApplicationCache
{
	[Event(ProtocolName.ApplicationCache.ApplicationCacheStatusUpdated)]
	[SupportedBy("Chrome-Tip")]
	public class ApplicationCacheStatusUpdatedEvent
	{
		/// <summary>
		/// Gets or sets Identifier of the frame containing document whose application cache updated status.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string FrameId { get; set; }
		/// <summary>
		/// Gets or sets Manifest URL.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string ManifestURL { get; set; }
		/// <summary>
		/// Gets or sets Updated application cache status.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long Status { get; set; }
	}
}
