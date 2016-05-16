using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Power
{
	/// <summary>
	/// Stop power events collection.
	/// </summary>
	[Command(ProtocolName.Power.End)]
	[SupportedBy("Chrome-Tip")]
	public class EndCommand
	{
	}
}
