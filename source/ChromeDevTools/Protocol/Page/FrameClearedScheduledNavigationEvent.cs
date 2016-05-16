using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Fired when frame no longer has a scheduled navigation.
	/// </summary>
	[Event(ProtocolName.Page.FrameClearedScheduledNavigation)]
	[SupportedBy("Chrome-Tip")]
	public class FrameClearedScheduledNavigationEvent
	{
		/// <summary>
		/// Gets or sets Id of the frame that has cleared its scheduled navigation.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string FrameId { get; set; }
	}
}
