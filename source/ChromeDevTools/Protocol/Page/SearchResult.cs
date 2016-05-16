using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Search result for resource.
	/// </summary>
	[SupportedBy("iOS-9.3")]
	public class SearchResult
	{
		/// <summary>
		/// Gets or sets Resource URL.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public string Url { get; set; }
		/// <summary>
		/// Gets or sets Resource frame id.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public string FrameId { get; set; }
		/// <summary>
		/// Gets or sets Number of matches in the resource content.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public double MatchesCount { get; set; }
	}
}
