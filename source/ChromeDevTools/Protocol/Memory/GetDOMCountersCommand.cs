using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Memory
{
	[Command(ProtocolName.Memory.GetDOMCounters)]
	[SupportedBy("Chrome-Tip")]
	public class GetDOMCountersCommand
	{
	}
}
