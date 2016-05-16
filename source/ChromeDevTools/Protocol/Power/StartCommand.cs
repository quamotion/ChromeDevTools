using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Power
{
	/// <summary>
	/// Start power events collection.
	/// </summary>
	[Command(ProtocolName.Power.Start)]
	[SupportedBy("Chrome-Tip")]
	public class StartCommand
	{
	}
}
