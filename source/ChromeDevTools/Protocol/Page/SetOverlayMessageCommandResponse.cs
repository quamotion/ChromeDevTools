using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Sets overlay message.
	/// </summary>
	[CommandResponse(ProtocolName.Page.SetOverlayMessage)]
	[SupportedBy("Chrome-Tip")]
	public class SetOverlayMessageCommandResponse
	{
	}
}
