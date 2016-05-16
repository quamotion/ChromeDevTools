using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.CSS
{
	/// <summary>
	/// Returns the computed style for a DOM node identified by <code>nodeId</code>.
	/// </summary>
	[CommandResponse(ProtocolName.CSS.GetComputedStyleForNode)]
	[SupportedBy("Chrome-Tip")]
	public class GetComputedStyleForNodeCommandResponse
	{
		/// <summary>
		/// Gets or sets Computed style for the specified DOM node.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public CSSComputedStyleProperty[] ComputedStyle { get; set; }
	}
}
