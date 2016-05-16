using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.ApplicationCache
{
	/// <summary>
	/// Detailed application cache resource information.
	/// </summary>
	[SupportedBy("Chrome-Tip")]
	public class ApplicationCacheResource
	{
		/// <summary>
		/// Gets or sets Resource url.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Url { get; set; }
		/// <summary>
		/// Gets or sets Resource size.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long Size { get; set; }
		/// <summary>
		/// Gets or sets Resource type.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Type { get; set; }
	}
}
