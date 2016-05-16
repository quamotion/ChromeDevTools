using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.ServiceWorker
{
	[CommandResponse(ProtocolName.ServiceWorker.InspectWorker)]
	[SupportedBy("Chrome-Tip")]
	public class InspectWorkerCommandResponse
	{
	}
}
