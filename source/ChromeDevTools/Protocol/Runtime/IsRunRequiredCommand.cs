using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Runtime
{
	[Command(ProtocolName.Runtime.IsRunRequired)]
	[SupportedBy("Chrome-Tip")]
	public class IsRunRequiredCommand
	{
	}
}
