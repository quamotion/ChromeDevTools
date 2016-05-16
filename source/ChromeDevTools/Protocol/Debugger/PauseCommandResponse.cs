using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Stops on the next JavaScript statement.
	/// </summary>
	[CommandResponse(ProtocolName.Debugger.Pause)]
	[SupportedBy("Chrome-Tip")]
	public class PauseCommandResponse
	{
	}
}
