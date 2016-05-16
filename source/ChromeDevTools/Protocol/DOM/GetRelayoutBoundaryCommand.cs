using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Returns the id of the nearest ancestor that is a relayout boundary.
	/// </summary>
	[Command(ProtocolName.DOM.GetRelayoutBoundary)]
	[SupportedBy("Chrome-Tip")]
	public class GetRelayoutBoundaryCommand
	{
		/// <summary>
		/// Gets or sets Id of the node.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long NodeId { get; set; }
	}
}
