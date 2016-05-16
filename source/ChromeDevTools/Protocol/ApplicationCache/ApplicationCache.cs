using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.ApplicationCache
{
	/// <summary>
	/// Detailed application cache information.
	/// </summary>
	[SupportedBy("Chrome-Tip")]
	public class ApplicationCache
	{
		/// <summary>
		/// Gets or sets Manifest URL.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string ManifestURL { get; set; }
		/// <summary>
		/// Gets or sets Application cache size.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public double Size { get; set; }
		/// <summary>
		/// Gets or sets Application cache creation time.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public double CreationTime { get; set; }
		/// <summary>
		/// Gets or sets Application cache update time.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public double UpdateTime { get; set; }
		/// <summary>
		/// Gets or sets Application cache resources.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public ApplicationCacheResource[] Resources { get; set; }
	}
}
