using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.CSS
{
	/// <summary>
	/// Returns the styles defined inline (explicitly in the "style" attribute and implicitly, using DOM attributes) for a DOM node identified by <code>nodeId</code>.
	/// </summary>
	[CommandResponse(ProtocolName.CSS.GetInlineStylesForNode)]
	[SupportedBy("Chrome-Tip")]
	[SupportedBy("iOS-9.3")]
	public class GetInlineStylesForNodeCommandResponse
	{
		/// <summary>
		/// Gets or sets Inline style for the specified DOM node.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		[SupportedBy("iOS-9.3")]
		public CSSStyle InlineStyle { get; set; }
		/// <summary>
		/// Gets or sets Attribute-defined element style (e.g. resulting from "width=20 height=100%").
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		[SupportedBy("iOS-9.3")]
		public CSSStyle AttributesStyle { get; set; }
	}
}
