using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Fired when frame has stopped loading.
	/// </summary>
	[Event(ProtocolName.Page.FrameStoppedLoading)]
	[SupportedBy("Chrome-Tip")]
	public class FrameStoppedLoadingEvent
	{
		/// <summary>
		/// Gets or sets Id of the frame that has stopped loading.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string FrameId { get; set; }
	}
}
