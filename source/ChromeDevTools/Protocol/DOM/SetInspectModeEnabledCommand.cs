using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Enters the 'inspect' mode. In this mode, elements that user is hovering over are highlighted. Backend then generates 'inspectNodeRequested' event upon element selection.
	/// </summary>
	[Command(ProtocolName.DOM.SetInspectModeEnabled)]
	[SupportedBy("Chrome-Tip")]
	public class SetInspectModeEnabledCommand
	{
		/// <summary>
		/// Gets or sets True to enable inspection mode, false to disable it.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		[SupportedBy("iOS-9.3")]
		public bool Enabled { get; set; }
		/// <summary>
		/// Gets or sets True to enable inspection mode for user agent shadow DOM.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public bool InspectUAShadowDOM { get; set; }
		/// <summary>
		/// Gets or sets A descriptor for the highlight appearance of hovered-over nodes. May be omitted if <code>enabled == false</code>.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		[SupportedBy("iOS-9.3")]
		public HighlightConfig HighlightConfig { get; set; }
	}
}
