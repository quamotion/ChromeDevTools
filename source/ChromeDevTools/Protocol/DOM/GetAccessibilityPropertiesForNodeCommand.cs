using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Returns a dictionary of accessibility properties for the node.
	/// </summary>
	[Command(ProtocolName.DOM.GetAccessibilityPropertiesForNode)]
	[SupportedBy("iOS-9.3")]
	public class GetAccessibilityPropertiesForNodeCommand
	{
		/// <summary>
		/// Gets or sets Id of the node for which to get accessibility properties.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public long NodeId { get; set; }
	}
}
