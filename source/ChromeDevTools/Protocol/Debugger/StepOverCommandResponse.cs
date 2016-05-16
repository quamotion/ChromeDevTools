using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Steps over the statement.
	/// </summary>
	[CommandResponse(ProtocolName.Debugger.StepOver)]
	[SupportedBy("Chrome-Tip")]
	[SupportedBy("iOS-9.3")]
	public class StepOverCommandResponse
	{
	}
}
