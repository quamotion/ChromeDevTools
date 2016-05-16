using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.ServiceWorker
{
	/// <summary>
	/// ServiceWorker version.
	/// </summary>
	[SupportedBy("Chrome-Tip")]
	public class ServiceWorkerVersion
	{
		/// <summary>
		/// Gets or sets VersionId
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string VersionId { get; set; }
		/// <summary>
		/// Gets or sets RegistrationId
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string RegistrationId { get; set; }
		/// <summary>
		/// Gets or sets ScriptURL
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string ScriptURL { get; set; }
		/// <summary>
		/// Gets or sets RunningStatus
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public ServiceWorkerVersionRunningStatus RunningStatus { get; set; }
		/// <summary>
		/// Gets or sets Status
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public ServiceWorkerVersionStatus Status { get; set; }
		/// <summary>
		/// Gets or sets The Last-Modified header value of the main script.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public double ScriptLastModified { get; set; }
		/// <summary>
		/// Gets or sets The time at which the response headers of the main script were received from the server.  For cached script it is the last time the cache entry was validated.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public double ScriptResponseTime { get; set; }
	}
}
