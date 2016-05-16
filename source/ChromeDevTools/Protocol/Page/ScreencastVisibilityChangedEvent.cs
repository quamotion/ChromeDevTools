using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Fired when the page with currently enabled screencast was shown or hidden </code>.
	/// </summary>
	[Event(ProtocolName.Page.ScreencastVisibilityChanged)]
	[SupportedBy("Chrome-Tip")]
	public class ScreencastVisibilityChangedEvent
	{
		/// <summary>
		/// Gets or sets True if the page is visible.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public bool Visible { get; set; }
	}
}
