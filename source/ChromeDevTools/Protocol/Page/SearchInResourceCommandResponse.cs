using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Searches for given string in resource content.
	/// </summary>
	[CommandResponse(ProtocolName.Page.SearchInResource)]
	[SupportedBy("Chrome-Tip")]
	public class SearchInResourceCommandResponse
	{
		/// <summary>
		/// Gets or sets List of search matches.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public Debugger.SearchMatch[] Result { get; set; }
	}
}
