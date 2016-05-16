using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Emulation
{
	/// <summary>
	/// Clears the overriden device metrics.
	/// </summary>
	[CommandResponse(ProtocolName.Emulation.ClearDeviceMetricsOverride)]
	[SupportedBy("Chrome-Tip")]
	public class ClearDeviceMetricsOverrideCommandResponse
	{
	}
}
