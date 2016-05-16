using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Accessibility
{
	/// <summary>
	/// Fetches the accessibility node for this DOM node, if it exists.
	/// </summary>
	[CommandResponse(ProtocolName.Accessibility.GetAXNode)]
	[SupportedBy("Chrome-Tip")]
	public class GetAXNodeCommandResponse
	{
		/// <summary>
		/// Gets or sets The <code>Accessibility.AXNode</code> for this DOM node, if it exists.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public AXNode AccessibilityNode { get; set; }
	}
}
