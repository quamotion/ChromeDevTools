using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Animation
{
	/// <summary>
	/// Enables animation domain notifications.
	/// </summary>
	[CommandResponse(ProtocolName.Animation.Enable)]
	[SupportedBy("Chrome-Tip")]
	public class EnableCommandResponse
	{
	}
}
