using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Search match for resource.
	/// </summary>
	[SupportedBy("Chrome-Tip")]
	public class SearchMatch
	{
		/// <summary>
		/// Gets or sets Line number in resource content.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public double LineNumber { get; set; }
		/// <summary>
		/// Gets or sets Line with match content.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string LineContent { get; set; }
	}
}
