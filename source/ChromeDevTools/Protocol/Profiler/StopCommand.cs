using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Profiler
{
	[Command(ProtocolName.Profiler.Stop)]
	[SupportedBy("Chrome-Tip")]
	public class StopCommand
	{
	}
}
