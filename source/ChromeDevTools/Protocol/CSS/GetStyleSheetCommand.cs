using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.CSS
{
	/// <summary>
	/// Returns stylesheet data for the specified <code>styleSheetId</code>.
	/// </summary>
	[Command(ProtocolName.CSS.GetStyleSheet)]
	[SupportedBy("iOS-9.3")]
	public class GetStyleSheetCommand
	{
		/// <summary>
		/// Gets or sets StyleSheetId
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public string StyleSheetId { get; set; }
	}
}
