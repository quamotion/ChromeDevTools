using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Searches for given string in script content.
	/// </summary>
	[CommandResponse(ProtocolName.Debugger.SearchInContent)]
	[SupportedBy("Chrome-Tip")]
	public class SearchInContentCommandResponse
	{
		/// <summary>
		/// Gets or sets List of search matches.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public SearchMatch[] Result { get; set; }
	}
}
