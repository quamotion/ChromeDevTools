using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Requests that group of <code>BackendNodeIds</code> is released.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.ReleaseBackendNodeIds)]
	[SupportedBy("iOS-9.3")]
	public class ReleaseBackendNodeIdsCommandResponse
	{
	}
}
