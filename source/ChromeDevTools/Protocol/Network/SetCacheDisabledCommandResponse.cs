using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Network
{
	/// <summary>
	/// Toggles ignoring cache for each request. If <code>true</code>, cache will not be used.
	/// </summary>
	[CommandResponse(ProtocolName.Network.SetCacheDisabled)]
	[SupportedBy("Chrome-Tip")]
	public class SetCacheDisabledCommandResponse
	{
	}
}
