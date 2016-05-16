using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Inspector
{
	/// <summary>
	/// Enables inspector domain notifications.
	/// </summary>
	[CommandResponse(ProtocolName.Inspector.Enable)]
	[SupportedBy("Chrome-Tip")]
	public class EnableCommandResponse
	{
	}
}
