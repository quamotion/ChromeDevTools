using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.CSS
{
	/// <summary>
	/// Returns all supported CSS property names.
	/// </summary>
	[Command(ProtocolName.CSS.GetSupportedCSSProperties)]
	[SupportedBy("iOS-9.3")]
	public class GetSupportedCSSPropertiesCommand
	{
	}
}
