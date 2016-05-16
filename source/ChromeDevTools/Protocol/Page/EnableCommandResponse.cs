using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Enables page domain notifications.
	/// </summary>
	[CommandResponse(ProtocolName.Page.Enable)]
	[SupportedBy("Chrome-Tip")]
	public class EnableCommandResponse
	{
	}
}
