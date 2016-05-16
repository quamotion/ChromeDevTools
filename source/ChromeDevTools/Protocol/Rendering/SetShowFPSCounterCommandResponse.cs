using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Rendering
{
	/// <summary>
	/// Requests that backend shows the FPS counter
	/// </summary>
	[CommandResponse(ProtocolName.Rendering.SetShowFPSCounter)]
	[SupportedBy("Chrome-Tip")]
	public class SetShowFPSCounterCommandResponse
	{
	}
}
