using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Network
{
	/// <summary>
	/// Timing information for the request.
	/// </summary>
	[SupportedBy("Chrome-Tip")]
	public class ResourceTiming
	{
		/// <summary>
		/// Gets or sets Timing's requestTime is a baseline in seconds, while the other numbers are ticks in milliseconds relatively to this requestTime.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public double RequestTime { get; set; }
		/// <summary>
		/// Gets or sets Started resolving proxy.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public double ProxyStart { get; set; }
		/// <summary>
		/// Gets or sets Finished resolving proxy.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public double ProxyEnd { get; set; }
		/// <summary>
		/// Gets or sets Started DNS address resolve.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public double DnsStart { get; set; }
		/// <summary>
		/// Gets or sets Finished DNS address resolve.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public double DnsEnd { get; set; }
		/// <summary>
		/// Gets or sets Started connecting to the remote host.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public double ConnectStart { get; set; }
		/// <summary>
		/// Gets or sets Connected to the remote host.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public double ConnectEnd { get; set; }
		/// <summary>
		/// Gets or sets Started SSL handshake.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public double SslStart { get; set; }
		/// <summary>
		/// Gets or sets Finished SSL handshake.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public double SslEnd { get; set; }
		/// <summary>
		/// Gets or sets Started fetching via ServiceWorker.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public double ServiceWorkerFetchStart { get; set; }
		/// <summary>
		/// Gets or sets Prepared a ServiceWorker.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public double ServiceWorkerFetchReady { get; set; }
		/// <summary>
		/// Gets or sets Finished fetching via ServiceWorker.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public double ServiceWorkerFetchEnd { get; set; }
		/// <summary>
		/// Gets or sets Started sending request.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public double SendStart { get; set; }
		/// <summary>
		/// Gets or sets Finished sending request.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public double SendEnd { get; set; }
		/// <summary>
		/// Gets or sets Finished receiving response headers.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public double ReceiveHeadersEnd { get; set; }
	}
}
