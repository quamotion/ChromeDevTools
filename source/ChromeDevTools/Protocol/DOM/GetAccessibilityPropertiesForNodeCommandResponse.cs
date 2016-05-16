using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Returns a dictionary of accessibility properties for the node.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.GetAccessibilityPropertiesForNode)]
	[SupportedBy("iOS-9.3")]
	public class GetAccessibilityPropertiesForNodeCommandResponse
	{
		/// <summary>
		/// Gets or sets Dictionary of relevant accessibility properties.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public AccessibilityProperties Properties { get; set; }
	}
}
