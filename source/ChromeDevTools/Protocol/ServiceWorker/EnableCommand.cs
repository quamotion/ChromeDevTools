using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.ServiceWorker
{
	[Command(ProtocolName.ServiceWorker.Enable)]
	[SupportedBy("Chrome-Tip")]
	public class EnableCommand
	{
	}
}
