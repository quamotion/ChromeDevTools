using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Network
{
	/// <summary>
	/// Tells whether clearing browser cookies is supported.
	/// </summary>
	[Command(ProtocolName.Network.CanClearBrowserCookies)]
	[SupportedBy("Chrome-Tip")]
	public class CanClearBrowserCookiesCommand
	{
	}
}
