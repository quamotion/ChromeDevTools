using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Creates a deep copy of the specified node and places it into the target container before the given anchor.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.CopyTo)]
	[SupportedBy("Chrome-Tip")]
	public class CopyToCommandResponse
	{
		/// <summary>
		/// Gets or sets Id of the node clone.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long NodeId { get; set; }
	}
}
