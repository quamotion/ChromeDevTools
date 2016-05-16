using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Network
{
	/// <summary>
	/// Returns content served for the given request.
	/// </summary>
	[CommandResponse(ProtocolName.Network.GetResponseBody)]
	[SupportedBy("Chrome-Tip")]
	public class GetResponseBodyCommandResponse
	{
		/// <summary>
		/// Gets or sets Response body.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Body { get; set; }
		/// <summary>
		/// Gets or sets True, if content was sent as base64.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public bool Base64Encoded { get; set; }
	}
}
