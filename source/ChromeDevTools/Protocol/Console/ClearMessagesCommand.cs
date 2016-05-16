using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Console
{
	/// <summary>
	/// Clears console messages collected in the browser.
	/// </summary>
	[Command(ProtocolName.Console.ClearMessages)]
	[SupportedBy("Chrome-Tip")]
	[SupportedBy("iOS-9.3")]
	public class ClearMessagesCommand
	{
	}
}
