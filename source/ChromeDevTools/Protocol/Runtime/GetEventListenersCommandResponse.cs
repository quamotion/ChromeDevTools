using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Runtime
{
	/// <summary>
	/// Returns event listeners of the given object.
	/// </summary>
	[CommandResponse(ProtocolName.Runtime.GetEventListeners)]
	[SupportedBy("Chrome-Tip")]
	public class GetEventListenersCommandResponse
	{
		/// <summary>
		/// Gets or sets Array of relevant listeners.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public EventListener[] Listeners { get; set; }
	}
}
