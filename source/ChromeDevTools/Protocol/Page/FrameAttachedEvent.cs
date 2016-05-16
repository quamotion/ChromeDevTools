using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Fired when frame has been attached to its parent.
	/// </summary>
	[Event(ProtocolName.Page.FrameAttached)]
	[SupportedBy("Chrome-Tip")]
	public class FrameAttachedEvent
	{
		/// <summary>
		/// Gets or sets Id of the frame that has been attached.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string FrameId { get; set; }
		/// <summary>
		/// Gets or sets Parent frame identifier.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string ParentFrameId { get; set; }
	}
}
