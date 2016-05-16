using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Network
{
	/// <summary>
	/// Specifies whether to always send extra HTTP headers with the requests from this page.
	/// </summary>
	[Command(ProtocolName.Network.SetExtraHTTPHeaders)]
	[SupportedBy("Chrome-Tip")]
	public class SetExtraHTTPHeadersCommand
	{
		/// <summary>
		/// Gets or sets Map with extra HTTP headers.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public Dictionary<string, string> Headers { get; set; }
	}
}
