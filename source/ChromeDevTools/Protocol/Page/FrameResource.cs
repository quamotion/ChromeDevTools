using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// 
	/// </summary>
	[SupportedBy("iOS-9.3")]
	public class FrameResource
	{
		/// <summary>
		/// Gets or sets Resource URL.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public string Url { get; set; }
		/// <summary>
		/// Gets or sets Type of this resource.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public ResourceType Type { get; set; }
		/// <summary>
		/// Gets or sets Resource mimeType as determined by the browser.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public string MimeType { get; set; }
		/// <summary>
		/// Gets or sets True if the resource failed to load.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public bool Failed { get; set; }
		/// <summary>
		/// Gets or sets True if the resource was canceled during loading.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public bool Canceled { get; set; }
		/// <summary>
		/// Gets or sets URL of source map associated with this resource (if any).
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public string SourceMapURL { get; set; }
	}
}
