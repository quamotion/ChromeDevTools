using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.CSS
{
	/// <summary>
	/// Returns metainfo entries for all known stylesheets.
	/// </summary>
	[CommandResponse(ProtocolName.CSS.GetAllStyleSheets)]
	[SupportedBy("iOS-9.3")]
	public class GetAllStyleSheetsCommandResponse
	{
		/// <summary>
		/// Gets or sets Descriptor entries for all available stylesheets.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public CSSStyleSheetHeader[] Headers { get; set; }
	}
}
