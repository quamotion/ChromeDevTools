using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Canvas
{
	[CommandResponse(ProtocolName.Canvas.StopCapturing)]
	[SupportedBy("Chrome-Tip")]
	public class StopCapturingCommandResponse
	{
	}
}
