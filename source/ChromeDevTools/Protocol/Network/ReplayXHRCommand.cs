using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Network
{
	/// <summary>
	/// This method sends a new XMLHttpRequest which is identical to the original one. The following parameters should be identical: method, url, async, request body, extra headers, withCredentials attribute, user, password.
	/// </summary>
	[Command(ProtocolName.Network.ReplayXHR)]
	[SupportedBy("Chrome-Tip")]
	public class ReplayXHRCommand
	{
		/// <summary>
		/// Gets or sets Identifier of XHR to replay.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string RequestId { get; set; }
	}
}
