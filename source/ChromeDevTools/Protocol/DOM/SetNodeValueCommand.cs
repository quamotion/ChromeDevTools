using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Sets node value for a node with given id.
	/// </summary>
	[Command(ProtocolName.DOM.SetNodeValue)]
	[SupportedBy("Chrome-Tip")]
	public class SetNodeValueCommand
	{
		/// <summary>
		/// Gets or sets Id of the node to set value for.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long NodeId { get; set; }
		/// <summary>
		/// Gets or sets New node's value.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Value { get; set; }
	}
}
