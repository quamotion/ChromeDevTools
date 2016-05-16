using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Network
{
	/// <summary>
	/// Tells whether clearing browser cache is supported.
	/// </summary>
	[Command(ProtocolName.Network.CanClearBrowserCache)]
	[SupportedBy("Chrome-Tip")]
	public class CanClearBrowserCacheCommand
	{
	}
}
