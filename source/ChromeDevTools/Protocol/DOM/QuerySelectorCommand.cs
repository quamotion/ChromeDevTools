using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Executes <code>querySelector</code> on a given node.
	/// </summary>
	[Command(ProtocolName.DOM.QuerySelector)]
	[SupportedBy("Chrome-Tip")]
	public class QuerySelectorCommand
	{
		/// <summary>
		/// Gets or sets Id of the node to query upon.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long NodeId { get; set; }
		/// <summary>
		/// Gets or sets Selector string.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Selector { get; set; }
	}
}
