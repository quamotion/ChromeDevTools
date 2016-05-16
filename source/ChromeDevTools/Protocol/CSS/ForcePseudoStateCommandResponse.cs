using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.CSS
{
	/// <summary>
	/// Ensures that the given node will have specified pseudo-classes whenever its style is computed by the browser.
	/// </summary>
	[CommandResponse(ProtocolName.CSS.ForcePseudoState)]
	[SupportedBy("Chrome-Tip")]
	[SupportedBy("iOS-9.3")]
	public class ForcePseudoStateCommandResponse
	{
	}
}
