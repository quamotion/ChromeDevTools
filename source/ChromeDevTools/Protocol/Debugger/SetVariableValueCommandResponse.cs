using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Changes value of variable in a callframe or a closure. Either callframe or function must be specified. Object-based scopes are not supported and must be mutated manually.
	/// </summary>
	[CommandResponse(ProtocolName.Debugger.SetVariableValue)]
	[SupportedBy("Chrome-Tip")]
	public class SetVariableValueCommandResponse
	{
	}
}
