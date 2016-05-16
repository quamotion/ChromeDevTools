using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Network
{
	/// <summary>
	/// HTTP response data.
	/// </summary>
	[SupportedBy("Chrome-Tip")]
	public class Response
	{
		/// <summary>
		/// Gets or sets Response URL. This URL can be different from CachedResource.url in case of redirect.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		[SupportedBy("iOS-9.3")]
		public string Url { get; set; }
		/// <summary>
		/// Gets or sets HTTP response status code.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		[SupportedBy("iOS-9.3")]
		public double Status { get; set; }
		/// <summary>
		/// Gets or sets HTTP response status text.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		[SupportedBy("iOS-9.3")]
		public string StatusText { get; set; }
		/// <summary>
		/// Gets or sets HTTP response headers.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		[SupportedBy("iOS-9.3")]
		public Dictionary<string, string> Headers { get; set; }
		/// <summary>
		/// Gets or sets HTTP response headers text.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		[SupportedBy("iOS-9.3")]
		public string HeadersText { get; set; }
		/// <summary>
		/// Gets or sets Resource mimeType as determined by the browser.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		[SupportedBy("iOS-9.3")]
		public string MimeType { get; set; }
		/// <summary>
		/// Gets or sets Refined HTTP request headers that were actually transmitted over the network.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		[SupportedBy("iOS-9.3")]
		public Dictionary<string, string> RequestHeaders { get; set; }
		/// <summary>
		/// Gets or sets HTTP request headers text.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		[SupportedBy("iOS-9.3")]
		public string RequestHeadersText { get; set; }
		/// <summary>
		/// Gets or sets Specifies whether physical connection was actually reused for this request.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public bool ConnectionReused { get; set; }
		/// <summary>
		/// Gets or sets Physical connection id that was actually used for this request.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public double ConnectionId { get; set; }
		/// <summary>
		/// Gets or sets Remote IP address.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string RemoteIPAddress { get; set; }
		/// <summary>
		/// Gets or sets Remote port.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long RemotePort { get; set; }
		/// <summary>
		/// Gets or sets Specifies that the request was served from the disk cache.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		[SupportedBy("iOS-9.3")]
		public bool FromDiskCache { get; set; }
		/// <summary>
		/// Gets or sets Specifies that the request was served from the ServiceWorker.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public bool FromServiceWorker { get; set; }
		/// <summary>
		/// Gets or sets Total number of bytes received for this request so far.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public double EncodedDataLength { get; set; }
		/// <summary>
		/// Gets or sets Timing information for the given request.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		[SupportedBy("iOS-9.3")]
		public ResourceTiming Timing { get; set; }
		/// <summary>
		/// Gets or sets Protocol used to fetch this resquest.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Protocol { get; set; }
	}
}
