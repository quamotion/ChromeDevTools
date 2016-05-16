using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Network
{
	/// <summary>
	/// Deletes browser cookie with given name, domain and path.
	/// </summary>
	[Command(ProtocolName.Network.DeleteCookie)]
	[SupportedBy("Chrome-Tip")]
	public class DeleteCookieCommand
	{
		/// <summary>
		/// Gets or sets Name of the cookie to remove.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string CookieName { get; set; }
		/// <summary>
		/// Gets or sets URL to match cooke domain and path.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Url { get; set; }
	}
}
