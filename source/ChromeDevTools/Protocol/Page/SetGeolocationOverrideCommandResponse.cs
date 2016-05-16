using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Overrides the Geolocation Position or Error. Omitting any of the parameters emulates position unavailable.
	/// </summary>
	[CommandResponse(ProtocolName.Page.SetGeolocationOverride)]
	[SupportedBy("Chrome-Tip")]
	public class SetGeolocationOverrideCommandResponse
	{
	}
}
