using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Fired when frame has been detached from its parent.
	/// </summary>
	[Event(ProtocolName.Page.FrameDetached)]
	[SupportedBy("Chrome-Tip")]
	public class FrameDetachedEvent
	{
		/// <summary>
		/// Gets or sets Id of the frame that has been detached.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string FrameId { get; set; }
	}
}
