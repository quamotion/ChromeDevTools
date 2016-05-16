using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Removes node with given id.
	/// </summary>
	[Command(ProtocolName.DOM.RemoveNode)]
	[SupportedBy("Chrome-Tip")]
	public class RemoveNodeCommand
	{
		/// <summary>
		/// Gets or sets Id of the node to remove.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long NodeId { get; set; }
	}
}
