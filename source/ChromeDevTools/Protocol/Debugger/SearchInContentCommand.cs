using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Searches for given string in script content.
	/// </summary>
	[Command(ProtocolName.Debugger.SearchInContent)]
	[SupportedBy("Chrome-Tip")]
	public class SearchInContentCommand
	{
		/// <summary>
		/// Gets or sets Id of the script to search in.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		[SupportedBy("iOS-9.3")]
		public string ScriptId { get; set; }
		/// <summary>
		/// Gets or sets String to search for.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		[SupportedBy("iOS-9.3")]
		public string Query { get; set; }
		/// <summary>
		/// Gets or sets If true, search is case sensitive.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		[SupportedBy("iOS-9.3")]
		public bool CaseSensitive { get; set; }
		/// <summary>
		/// Gets or sets If true, treats string parameter as regex.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		[SupportedBy("iOS-9.3")]
		public bool IsRegex { get; set; }
	}
}
