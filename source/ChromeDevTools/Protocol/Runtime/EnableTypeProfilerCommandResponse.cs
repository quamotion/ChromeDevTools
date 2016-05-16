using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Runtime
{
	/// <summary>
	/// Enables type profiling on the VM.
	/// </summary>
	[CommandResponse(ProtocolName.Runtime.EnableTypeProfiler)]
	[SupportedBy("iOS-9.3")]
	public class EnableTypeProfilerCommandResponse
	{
	}
}
