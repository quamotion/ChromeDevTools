using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Worker
{
	[CommandResponse(ProtocolName.Worker.Enable)]
	[SupportedBy("Chrome-Tip")]
	public class EnableCommandResponse
	{
	}
}
