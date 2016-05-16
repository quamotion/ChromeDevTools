using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.ApplicationCache
{
	/// <summary>
	/// Frame identifier - manifest URL pair.
	/// </summary>
	[SupportedBy("Chrome-Tip")]
	public class FrameWithManifest
	{
		/// <summary>
		/// Gets or sets Frame identifier.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string FrameId { get; set; }
		/// <summary>
		/// Gets or sets Manifest URL.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string ManifestURL { get; set; }
		/// <summary>
		/// Gets or sets Application cache status.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long Status { get; set; }
	}
}
