using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Worker
{
	[CommandResponse(ProtocolName.Worker.SendMessageToWorker)]
	[SupportedBy("Chrome-Tip")]
	public class SendMessageToWorkerCommandResponse
	{
	}
}
