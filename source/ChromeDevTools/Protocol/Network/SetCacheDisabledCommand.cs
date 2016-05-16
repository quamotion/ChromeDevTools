using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Network
{
	/// <summary>
	/// Toggles ignoring cache for each request. If <code>true</code>, cache will not be used.
	/// </summary>
	[Command(ProtocolName.Network.SetCacheDisabled)]
	[SupportedBy("Chrome-Tip")]
	public class SetCacheDisabledCommand
	{
		/// <summary>
		/// Gets or sets Cache disabled state.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public bool CacheDisabled { get; set; }
	}
}
