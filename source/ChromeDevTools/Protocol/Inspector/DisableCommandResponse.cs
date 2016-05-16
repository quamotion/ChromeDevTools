using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Inspector
{
	/// <summary>
	/// Disables inspector domain notifications.
	/// </summary>
	[CommandResponse(ProtocolName.Inspector.Disable)]
	[SupportedBy("Chrome-Tip")]
	[SupportedBy("iOS-9.3")]
	public class DisableCommandResponse
	{
	}
}
