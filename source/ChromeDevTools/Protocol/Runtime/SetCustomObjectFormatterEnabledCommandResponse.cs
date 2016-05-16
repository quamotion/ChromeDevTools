using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Runtime
{
	[CommandResponse(ProtocolName.Runtime.SetCustomObjectFormatterEnabled)]
	[SupportedBy("Chrome-Tip")]
	public class SetCustomObjectFormatterEnabledCommandResponse
	{
	}
}
