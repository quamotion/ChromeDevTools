using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.CSS
{
	/// <summary>
	/// Returns all supported system font family names.
	/// </summary>
	[Command(ProtocolName.CSS.GetSupportedSystemFontFamilyNames)]
	[SupportedBy("iOS-9.3")]
	public class GetSupportedSystemFontFamilyNamesCommand
	{
	}
}
