using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Requests that the node is sent to the caller given its backend node id.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.PushNodeByBackendIdToFrontend)]
	[SupportedBy("iOS-9.3")]
	public class PushNodeByBackendIdToFrontendCommandResponse
	{
		/// <summary>
		/// Gets or sets The pushed node's id.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public long NodeId { get; set; }
	}
}
