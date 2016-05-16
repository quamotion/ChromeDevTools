using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Emulates the given media for CSS media queries.
	/// </summary>
	[CommandResponse(ProtocolName.Page.SetEmulatedMedia)]
	[SupportedBy("iOS-9.3")]
	public class SetEmulatedMediaCommandResponse
	{
	}
}
