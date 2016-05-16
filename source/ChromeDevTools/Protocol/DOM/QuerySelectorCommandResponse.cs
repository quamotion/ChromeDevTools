using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Executes <code>querySelector</code> on a given node.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.QuerySelector)]
	[SupportedBy("Chrome-Tip")]
	public class QuerySelectorCommandResponse
	{
		/// <summary>
		/// Gets or sets Query selector result.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long NodeId { get; set; }
	}
}
