using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Resolves JavaScript node object for given node id.
	/// </summary>
	[Command(ProtocolName.DOM.ResolveNode)]
	[SupportedBy("Chrome-Tip")]
	public class ResolveNodeCommand
	{
		/// <summary>
		/// Gets or sets Id of the node to resolve.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long NodeId { get; set; }
		/// <summary>
		/// Gets or sets Symbolic group name that can be used to release multiple objects.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string ObjectGroup { get; set; }
	}
}
