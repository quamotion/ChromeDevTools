using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Sets overlay message.
	/// </summary>
	[CommandResponse(ProtocolName.Debugger.SetOverlayMessage)]
	[SupportedBy("iOS-9.3")]
	public class SetOverlayMessageCommandResponse
	{
	}
}
