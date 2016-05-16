using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Network
{
	/// <summary>
	/// Information about the cached resource.
	/// </summary>
	[SupportedBy("Chrome-Tip")]
	public class CachedResource
	{
		/// <summary>
		/// Gets or sets Resource URL. This is the url of the original network request.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Url { get; set; }
		/// <summary>
		/// Gets or sets Type of this resource.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public Page.ResourceType Type { get; set; }
		/// <summary>
		/// Gets or sets Cached response data.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public Response Response { get; set; }
		/// <summary>
		/// Gets or sets Cached response body size.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public double BodySize { get; set; }
	}
}
