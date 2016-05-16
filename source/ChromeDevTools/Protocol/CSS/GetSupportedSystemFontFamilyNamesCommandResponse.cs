using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.CSS
{
	/// <summary>
	/// Returns all supported system font family names.
	/// </summary>
	[CommandResponse(ProtocolName.CSS.GetSupportedSystemFontFamilyNames)]
	[SupportedBy("iOS-9.3")]
	public class GetSupportedSystemFontFamilyNamesCommandResponse
	{
		/// <summary>
		/// Gets or sets Supported system font families.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public string[] FontFamilyNames { get; set; }
	}
}
