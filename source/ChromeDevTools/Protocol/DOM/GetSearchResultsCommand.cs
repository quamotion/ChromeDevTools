using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Returns search results from given <code>fromIndex</code> to given <code>toIndex</code> from the sarch with the given identifier.
	/// </summary>
	[Command(ProtocolName.DOM.GetSearchResults)]
	[SupportedBy("Chrome-Tip")]
	[SupportedBy("iOS-9.3")]
	public class GetSearchResultsCommand
	{
		/// <summary>
		/// Gets or sets Unique search session identifier.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		[SupportedBy("iOS-9.3")]
		public string SearchId { get; set; }
		/// <summary>
		/// Gets or sets Start index of the search result to be returned.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		[SupportedBy("iOS-9.3")]
		public long FromIndex { get; set; }
		/// <summary>
		/// Gets or sets End index of the search result to be returned.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		[SupportedBy("iOS-9.3")]
		public long ToIndex { get; set; }
	}
}
