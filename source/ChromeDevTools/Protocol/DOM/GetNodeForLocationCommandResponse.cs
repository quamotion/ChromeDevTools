using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Returns node id at given location.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.GetNodeForLocation)]
	[SupportedBy("Chrome-Tip")]
	public class GetNodeForLocationCommandResponse
	{
		/// <summary>
		/// Gets or sets Id of the node at given coordinates.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long NodeId { get; set; }
	}
}
