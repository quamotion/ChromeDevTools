using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Returns event listeners relevant to the node.
	/// </summary>
	[Command(ProtocolName.DOM.GetEventListenersForNode)]
	[SupportedBy("Chrome-Tip")]
	[SupportedBy("iOS-9.3")]
	public class GetEventListenersForNodeCommand
	{
		/// <summary>
		/// Gets or sets Id of the node to get listeners for.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		[SupportedBy("iOS-9.3")]
		public long NodeId { get; set; }
		/// <summary>
		/// Gets or sets Symbolic group name for handler value. Handler value is not returned without this parameter specified.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		[SupportedBy("iOS-9.3")]
		public string ObjectGroup { get; set; }
	}
}
