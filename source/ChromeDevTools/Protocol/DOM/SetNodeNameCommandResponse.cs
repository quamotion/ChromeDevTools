using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Sets node name for a node with given id.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.SetNodeName)]
	[SupportedBy("Chrome-Tip")]
	public class SetNodeNameCommandResponse
	{
		/// <summary>
		/// Gets or sets New node's id.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long NodeId { get; set; }
	}
}
