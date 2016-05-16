using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.GenericTypes
{
	/// <summary>
	/// Search match in a resource.
	/// </summary>
	[SupportedBy("iOS-9.3")]
	public class SearchMatch
	{
		/// <summary>
		/// Gets or sets Line number in resource content.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public double LineNumber { get; set; }
		/// <summary>
		/// Gets or sets Line with match content.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public string LineContent { get; set; }
	}
}
