using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Fired when the JavaScript is enabled/disabled on the page
	/// </summary>
	[Event(ProtocolName.Page.ScriptsEnabled)]
	[SupportedBy("iOS-9.3")]
	public class ScriptsEnabledEvent
	{
		/// <summary>
		/// Gets or sets Whether script execution is enabled or disabled on the page.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public bool IsEnabled { get; set; }
	}
}
