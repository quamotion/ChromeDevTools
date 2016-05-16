using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Fired when a color has been picked.
	/// </summary>
	[Event(ProtocolName.Page.ColorPicked)]
	[SupportedBy("Chrome-Tip")]
	public class ColorPickedEvent
	{
		/// <summary>
		/// Gets or sets RGBA of the picked color.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public DOM.RGBA Color { get; set; }
	}
}
