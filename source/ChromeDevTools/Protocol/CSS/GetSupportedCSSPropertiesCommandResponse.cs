using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.CSS
{
	/// <summary>
	/// Returns all supported CSS property names.
	/// </summary>
	[CommandResponse(ProtocolName.CSS.GetSupportedCSSProperties)]
	[SupportedBy("iOS-9.3")]
	public class GetSupportedCSSPropertiesCommandResponse
	{
		/// <summary>
		/// Gets or sets Supported property metainfo.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public CSSPropertyInfo[] CssProperties { get; set; }
	}
}
