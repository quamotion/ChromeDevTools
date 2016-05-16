using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Switches script execution in the page.
	/// </summary>
	[CommandResponse(ProtocolName.Page.SetScriptExecutionDisabled)]
	[SupportedBy("iOS-9.3")]
	public class SetScriptExecutionDisabledCommandResponse
	{
	}
}
