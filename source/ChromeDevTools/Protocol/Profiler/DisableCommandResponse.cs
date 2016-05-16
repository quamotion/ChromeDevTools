using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Profiler
{
	[CommandResponse(ProtocolName.Profiler.Disable)]
	[SupportedBy("Chrome-Tip")]
	public class DisableCommandResponse
	{
	}
}
