using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Network
{
	/// <summary>
	/// Allows overriding user agent with the given string.
	/// </summary>
	[Command(ProtocolName.Network.SetUserAgentOverride)]
	[SupportedBy("Chrome-Tip")]
	public class SetUserAgentOverrideCommand
	{
		/// <summary>
		/// Gets or sets User agent to use.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string UserAgent { get; set; }
	}
}
