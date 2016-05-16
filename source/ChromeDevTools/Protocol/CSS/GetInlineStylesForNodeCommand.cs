using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.CSS
{
	/// <summary>
	/// Returns the styles defined inline (explicitly in the "style" attribute and implicitly, using DOM attributes) for a DOM node identified by <code>nodeId</code>.
	/// </summary>
	[Command(ProtocolName.CSS.GetInlineStylesForNode)]
	[SupportedBy("Chrome-Tip")]
	public class GetInlineStylesForNodeCommand
	{
		/// <summary>
		/// Gets or sets NodeId
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long NodeId { get; set; }
	}
}
