using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Disables page domain notifications.
	/// </summary>
	[Command(ProtocolName.Page.Disable)]
	[SupportedBy("Chrome-Tip")]
	public class DisableCommand
	{
	}
}
