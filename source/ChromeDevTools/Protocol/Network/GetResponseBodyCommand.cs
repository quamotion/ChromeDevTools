using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Network
{
	/// <summary>
	/// Returns content served for the given request.
	/// </summary>
	[Command(ProtocolName.Network.GetResponseBody)]
	[SupportedBy("Chrome-Tip")]
	public class GetResponseBodyCommand
	{
		/// <summary>
		/// Gets or sets Identifier of the network request to get content for.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string RequestId { get; set; }
	}
}
