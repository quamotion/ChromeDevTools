using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Sets node HTML markup, returns new node id.
	/// </summary>
	[Command(ProtocolName.DOM.SetOuterHTML)]
	[SupportedBy("Chrome-Tip")]
	public class SetOuterHTMLCommand
	{
		/// <summary>
		/// Gets or sets Id of the node to set markup for.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long NodeId { get; set; }
		/// <summary>
		/// Gets or sets Outer HTML markup to set.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string OuterHTML { get; set; }
	}
}
