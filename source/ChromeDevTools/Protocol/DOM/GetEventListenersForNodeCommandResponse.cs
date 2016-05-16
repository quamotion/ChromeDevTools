using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Returns event listeners relevant to the node.
	/// </summary>
	[CommandResponse(ProtocolName.DOM.GetEventListenersForNode)]
	[SupportedBy("Chrome-Tip")]
	public class GetEventListenersForNodeCommandResponse
	{
		/// <summary>
		/// Gets or sets Array of relevant listeners.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public EventListener[] Listeners { get; set; }
	}
}
