using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.ServiceWorker
{
	[Command(ProtocolName.ServiceWorker.UpdateRegistration)]
	[SupportedBy("Chrome-Tip")]
	public class UpdateRegistrationCommand
	{
		/// <summary>
		/// Gets or sets ScopeURL
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string ScopeURL { get; set; }
	}
}
