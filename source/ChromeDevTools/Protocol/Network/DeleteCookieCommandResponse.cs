using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Network
{
	/// <summary>
	/// Deletes browser cookie with given name, domain and path.
	/// </summary>
	[CommandResponse(ProtocolName.Network.DeleteCookie)]
	[SupportedBy("Chrome-Tip")]
	public class DeleteCookieCommandResponse
	{
	}
}
