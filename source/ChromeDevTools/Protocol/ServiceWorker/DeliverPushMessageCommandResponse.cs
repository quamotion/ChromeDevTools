using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.ServiceWorker
{
	[CommandResponse(ProtocolName.ServiceWorker.DeliverPushMessage)]
	[SupportedBy("Chrome-Tip")]
	public class DeliverPushMessageCommandResponse
	{
	}
}
