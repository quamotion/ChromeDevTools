using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Network
{
	/// <summary>
	/// Clears browser cache.
	/// </summary>
	[CommandResponse(ProtocolName.Network.ClearBrowserCache)]
	[SupportedBy("Chrome-Tip")]
	public class ClearBrowserCacheCommandResponse
	{
	}
}
