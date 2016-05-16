using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Fired when frame has started loading.
	/// </summary>
	[Event(ProtocolName.Page.FrameStartedLoading)]
	[SupportedBy("Chrome-Tip")]
	public class FrameStartedLoadingEvent
	{
		/// <summary>
		/// Gets or sets Id of the frame that has started loading.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string FrameId { get; set; }
	}
}
