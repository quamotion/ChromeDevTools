using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Animation
{
	/// <summary>
	/// Enables animation domain notifications.
	/// </summary>
	[Command(ProtocolName.Animation.Enable)]
	[SupportedBy("Chrome-Tip")]
	public class EnableCommand
	{
	}
}
