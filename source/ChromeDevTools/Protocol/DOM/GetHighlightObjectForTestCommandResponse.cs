using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// For testing.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.GetHighlightObjectForTest)]
	[SupportedBy("Chrome-Tip")]
	public class GetHighlightObjectForTestCommandResponse
	{
		/// <summary>
		/// Gets or sets Highlight data for the node.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public object Highlight { get; set; }
	}
}
