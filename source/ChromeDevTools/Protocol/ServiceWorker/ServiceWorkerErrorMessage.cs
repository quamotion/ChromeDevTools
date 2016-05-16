using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.ServiceWorker
{
	/// <summary>
	/// ServiceWorker error message.
	/// </summary>
	[SupportedBy("Chrome-Tip")]
	public class ServiceWorkerErrorMessage
	{
		/// <summary>
		/// Gets or sets ErrorMessage
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string ErrorMessage { get; set; }
		/// <summary>
		/// Gets or sets RegistrationId
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string RegistrationId { get; set; }
		/// <summary>
		/// Gets or sets VersionId
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string VersionId { get; set; }
		/// <summary>
		/// Gets or sets SourceURL
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string SourceURL { get; set; }
		/// <summary>
		/// Gets or sets LineNumber
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long LineNumber { get; set; }
		/// <summary>
		/// Gets or sets ColumnNumber
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long ColumnNumber { get; set; }
	}
}
