using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Network
{
	/// <summary>
	/// Clears browser cookies.
	/// </summary>
	[CommandResponse(ProtocolName.Network.ClearBrowserCookies)]
	[SupportedBy("Chrome-Tip")]
	public class ClearBrowserCookiesCommandResponse
	{
	}
}
