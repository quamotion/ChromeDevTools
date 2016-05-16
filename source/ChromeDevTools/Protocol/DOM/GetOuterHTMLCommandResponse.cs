using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Returns node's HTML markup.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.GetOuterHTML)]
	[SupportedBy("Chrome-Tip")]
	public class GetOuterHTMLCommandResponse
	{
		/// <summary>
		/// Gets or sets Outer HTML markup.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string OuterHTML { get; set; }
	}
}
