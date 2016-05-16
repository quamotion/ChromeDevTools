using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Returns node's HTML markup.
	/// </summary>
	[Command(ProtocolName.DOM.GetOuterHTML)]
	[SupportedBy("Chrome-Tip")]
	public class GetOuterHTMLCommand
	{
		/// <summary>
		/// Gets or sets Id of the node to get markup for.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long NodeId { get; set; }
	}
}
