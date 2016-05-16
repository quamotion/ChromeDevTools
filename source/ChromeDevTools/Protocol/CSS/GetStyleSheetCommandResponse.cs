using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.CSS
{
	/// <summary>
	/// Returns stylesheet data for the specified <code>styleSheetId</code>.
	/// </summary>
	[CommandResponse(ProtocolName.CSS.GetStyleSheet)]
	[SupportedBy("iOS-9.3")]
	public class GetStyleSheetCommandResponse
	{
		/// <summary>
		/// Gets or sets Stylesheet contents for the specified <code>styleSheetId</code>.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public CSSStyleSheetBody StyleSheet { get; set; }
	}
}
