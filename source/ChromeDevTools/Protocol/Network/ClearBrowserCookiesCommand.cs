using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Network
{
	/// <summary>
	/// Clears browser cookies.
	/// </summary>
	[Command(ProtocolName.Network.ClearBrowserCookies)]
	[SupportedBy("Chrome-Tip")]
	[SupportedBy("iOS-9.3")]
	public class ClearBrowserCookiesCommand
	{
	}
}
