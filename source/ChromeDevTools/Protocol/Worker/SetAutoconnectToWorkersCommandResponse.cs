using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Worker
{
	[CommandResponse(ProtocolName.Worker.SetAutoconnectToWorkers)]
	[SupportedBy("Chrome-Tip")]
	public class SetAutoconnectToWorkersCommandResponse
	{
	}
}
