using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.CSS
{
	/// <summary>
	/// Fired whenever a stylesheet is changed as a result of the client operation.
	/// </summary>
	[Event(ProtocolName.CSS.StyleSheetChanged)]
	[SupportedBy("Chrome-Tip")]
	public class StyleSheetChangedEvent
	{
		/// <summary>
		/// Gets or sets StyleSheetId
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string StyleSheetId { get; set; }
	}
}
