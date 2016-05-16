using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.HeapProfiler
{
	[Command(ProtocolName.HeapProfiler.Disable)]
	[SupportedBy("Chrome-Tip")]
	public class DisableCommand
	{
	}
}
