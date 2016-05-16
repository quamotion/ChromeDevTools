using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Runtime
{
	/// <summary>
	/// Disables type profiling on the VM.
	/// </summary>
	[CommandResponse(ProtocolName.Runtime.DisableTypeProfiler)]
	[SupportedBy("iOS-9.3")]
	public class DisableTypeProfilerCommandResponse
	{
	}
}
