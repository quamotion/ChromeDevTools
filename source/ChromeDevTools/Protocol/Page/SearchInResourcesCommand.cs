using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Searches for given string in frame / resource tree structure.
	/// </summary>
	[Command(ProtocolName.Page.SearchInResources)]
	[SupportedBy("iOS-9.3")]
	public class SearchInResourcesCommand
	{
		/// <summary>
		/// Gets or sets String to search for.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public string Text { get; set; }
		/// <summary>
		/// Gets or sets If true, search is case sensitive.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public bool CaseSensitive { get; set; }
		/// <summary>
		/// Gets or sets If true, treats string parameter as regex.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public bool IsRegex { get; set; }
	}
}
