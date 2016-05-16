using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.CSS
{
	/// <summary>
	/// Returns all media queries parsed by the rendering engine.
	/// </summary>
	[Command(ProtocolName.CSS.GetMediaQueries)]
	[SupportedBy("Chrome-Tip")]
	public class GetMediaQueriesCommand
	{
	}
}
