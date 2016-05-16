using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Returns boxes for the currently selected nodes.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.GetBoxModel)]
	[SupportedBy("Chrome-Tip")]
	public class GetBoxModelCommandResponse
	{
		/// <summary>
		/// Gets or sets Box model for the node.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public BoxModel Model { get; set; }
	}
}
