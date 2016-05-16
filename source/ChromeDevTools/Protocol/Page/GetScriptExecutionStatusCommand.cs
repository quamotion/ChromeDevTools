using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Determines if scripts can be executed in the page.
	/// </summary>
	[Command(ProtocolName.Page.GetScriptExecutionStatus)]
	[SupportedBy("iOS-9.3")]
	public class GetScriptExecutionStatusCommand
	{
	}
}
