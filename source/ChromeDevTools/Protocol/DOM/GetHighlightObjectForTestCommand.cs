using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// For testing.
	/// </summary>
	[Command(ProtocolName.DOM.GetHighlightObjectForTest)]
	[SupportedBy("Chrome-Tip")]
	public class GetHighlightObjectForTestCommand
	{
		/// <summary>
		/// Gets or sets Id of the node to get highlight object for.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long NodeId { get; set; }
	}
}
