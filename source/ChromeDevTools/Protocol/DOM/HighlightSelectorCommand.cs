using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Highlights all DOM nodes that match a given selector. A string containing a CSS selector must be specified.
	/// </summary>
	[Command(ProtocolName.DOM.HighlightSelector)]
	[SupportedBy("iOS-9.3")]
	public class HighlightSelectorCommand
	{
		/// <summary>
		/// Gets or sets A descriptor for the highlight appearance.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public HighlightConfig HighlightConfig { get; set; }
		/// <summary>
		/// Gets or sets A CSS selector for finding matching nodes to highlight.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public string SelectorString { get; set; }
		/// <summary>
		/// Gets or sets Identifier of the frame which will be searched using the selector.  If not provided, the main frame will be used.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public string FrameId { get; set; }
	}
}
