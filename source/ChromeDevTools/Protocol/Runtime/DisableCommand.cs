using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Runtime
{
	/// <summary>
	/// Disables reporting of execution contexts creation.
	/// </summary>
	[Command(ProtocolName.Runtime.Disable)]
	[SupportedBy("Chrome-Tip")]
	public class DisableCommand
	{
	}
}
