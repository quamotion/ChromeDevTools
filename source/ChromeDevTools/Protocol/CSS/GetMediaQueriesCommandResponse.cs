using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.CSS
{
	/// <summary>
	/// Returns all media queries parsed by the rendering engine.
	/// </summary>
	[CommandResponse(ProtocolName.CSS.GetMediaQueries)]
	[SupportedBy("Chrome-Tip")]
	public class GetMediaQueriesCommandResponse
	{
		/// <summary>
		/// Gets or sets Medias
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public CSSMedia[] Medias { get; set; }
	}
}
