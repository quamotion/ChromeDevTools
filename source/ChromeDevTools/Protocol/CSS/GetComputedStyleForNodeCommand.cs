using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.CSS
{
	/// <summary>
	/// Returns the computed style for a DOM node identified by <code>nodeId</code>.
	/// </summary>
	[Command(ProtocolName.CSS.GetComputedStyleForNode)]
	[SupportedBy("Chrome-Tip")]
	public class GetComputedStyleForNodeCommand
	{
		/// <summary>
		/// Gets or sets NodeId
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long NodeId { get; set; }
	}
}
