using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Compressed image data requested by the <code>startScreencast</code>.
	/// </summary>
	[Event(ProtocolName.Page.ScreencastFrame)]
	[SupportedBy("Chrome-Tip")]
	public class ScreencastFrameEvent
	{
		/// <summary>
		/// Gets or sets Base64-encoded compressed image.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Data { get; set; }
		/// <summary>
		/// Gets or sets Screencast frame metadata.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public ScreencastFrameMetadata Metadata { get; set; }
		/// <summary>
		/// Gets or sets Frame number.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long FrameNumber { get; set; }
	}
}
