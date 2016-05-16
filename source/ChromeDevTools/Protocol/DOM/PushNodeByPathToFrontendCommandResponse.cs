using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Requests that the node is sent to the caller given its path. // FIXME, use XPath
	/// </summary>
	[CommandResponse(ProtocolName.DOM.PushNodeByPathToFrontend)]
	[SupportedBy("Chrome-Tip")]
	public class PushNodeByPathToFrontendCommandResponse
	{
		/// <summary>
		/// Gets or sets Id of the node for given path.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long NodeId { get; set; }
	}
}
