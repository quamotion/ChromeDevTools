using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Tracing
{
	/// <summary>
	/// Stop trace events collection.
	/// </summary>
	[Command(ProtocolName.Tracing.End)]
	[SupportedBy("Chrome-Tip")]
	public class EndCommand
	{
	}
}
