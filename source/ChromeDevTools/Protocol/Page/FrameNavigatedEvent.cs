using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Fired once navigation of the frame has completed. Frame is now associated with the new loader.
	/// </summary>
	[Event(ProtocolName.Page.FrameNavigated)]
	[SupportedBy("Chrome-Tip")]
	public class FrameNavigatedEvent
	{
		/// <summary>
		/// Gets or sets Frame object.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public Frame Frame { get; set; }
	}
}
