using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.HeapProfiler
{
	[CommandResponse(ProtocolName.HeapProfiler.StopTrackingHeapObjects)]
	[SupportedBy("Chrome-Tip")]
	public class StopTrackingHeapObjectsCommandResponse
	{
	}
}
