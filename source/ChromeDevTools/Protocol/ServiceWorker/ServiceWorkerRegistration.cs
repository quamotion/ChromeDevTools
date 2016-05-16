using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.ServiceWorker
{
	/// <summary>
	/// ServiceWorker registration.
	/// </summary>
	[SupportedBy("Chrome-Tip")]
	public class ServiceWorkerRegistration
	{
		/// <summary>
		/// Gets or sets RegistrationId
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string RegistrationId { get; set; }
		/// <summary>
		/// Gets or sets ScopeURL
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string ScopeURL { get; set; }
		/// <summary>
		/// Gets or sets IsDeleted
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public bool IsDeleted { get; set; }
	}
}
