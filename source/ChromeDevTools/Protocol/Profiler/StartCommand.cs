using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Profiler
{
	[Command(ProtocolName.Profiler.Start)]
	[SupportedBy("Chrome-Tip")]
	public class StartCommand
	{
	}
}
