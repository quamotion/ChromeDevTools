using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Searches for a given string in the DOM tree. Use <code>getSearchResults</code> to access search results or <code>cancelSearch</code> to end this search session.
	/// </summary>
	[Command(ProtocolName.DOM.PerformSearch)]
	[SupportedBy("Chrome-Tip")]
	public class PerformSearchCommand
	{
		/// <summary>
		/// Gets or sets Plain text or query selector or XPath search query.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Query { get; set; }
		/// <summary>
		/// Gets or sets True to search in user agent shadow DOM.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public bool IncludeUserAgentShadowDOM { get; set; }
	}
}
