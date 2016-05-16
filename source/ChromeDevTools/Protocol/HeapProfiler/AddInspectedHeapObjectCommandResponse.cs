using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.HeapProfiler
{
	/// <summary>
	/// Enables console to refer to the node with given id via $x (see Command Line API for more details $x functions).
	/// </summary>
	[CommandResponse(ProtocolName.HeapProfiler.AddInspectedHeapObject)]
	[SupportedBy("Chrome-Tip")]
	public class AddInspectedHeapObjectCommandResponse
	{
	}
}
