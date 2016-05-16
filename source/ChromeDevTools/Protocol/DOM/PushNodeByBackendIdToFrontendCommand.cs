using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Requests that the node is sent to the caller given its backend node id.
	/// </summary>
	[Command(ProtocolName.DOM.PushNodeByBackendIdToFrontend)]
	[SupportedBy("iOS-9.3")]
	public class PushNodeByBackendIdToFrontendCommand
	{
		/// <summary>
		/// Gets or sets The backend node id of the node.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public long BackendNodeId { get; set; }
	}
}