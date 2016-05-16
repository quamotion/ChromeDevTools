using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.CSS
{
	/// <summary>
	/// Fired whenever an active document stylesheet is removed.
	/// </summary>
	[Event(ProtocolName.CSS.StyleSheetRemoved)]
	[SupportedBy("Chrome-Tip")]
	public class StyleSheetRemovedEvent
	{
		/// <summary>
		/// Gets or sets Identifier of the removed stylesheet.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string StyleSheetId { get; set; }
	}
}
