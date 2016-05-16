using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.CSS
{
	/// <summary>
	/// Fired whenever an active document stylesheet is added.
	/// </summary>
	[Event(ProtocolName.CSS.StyleSheetAdded)]
	[SupportedBy("Chrome-Tip")]
	public class StyleSheetAddedEvent
	{
		/// <summary>
		/// Gets or sets Added stylesheet metainfo.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public CSSStyleSheetHeader Header { get; set; }
	}
}
