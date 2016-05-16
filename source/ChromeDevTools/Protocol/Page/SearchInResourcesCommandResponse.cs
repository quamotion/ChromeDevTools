using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Searches for given string in frame / resource tree structure.
	/// </summary>
	[CommandResponse(ProtocolName.Page.SearchInResources)]
	[SupportedBy("iOS-9.3")]
	public class SearchInResourcesCommandResponse
	{
		/// <summary>
		/// Gets or sets List of search results.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public SearchResult[] Result { get; set; }
	}
}
