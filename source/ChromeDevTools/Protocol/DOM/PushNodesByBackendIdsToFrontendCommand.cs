using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Requests that a batch of nodes is sent to the caller given their backend node ids.
	/// </summary>
	[Command(ProtocolName.DOM.PushNodesByBackendIdsToFrontend)]
	[SupportedBy("Chrome-Tip")]
	public class PushNodesByBackendIdsToFrontendCommand
	{
		/// <summary>
		/// Gets or sets The array of backend node ids.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long[] BackendNodeIds { get; set; }
	}
}
