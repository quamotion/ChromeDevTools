using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Accessibility
{
	/// <summary>
	/// Fetches the accessibility node for this DOM node, if it exists.
	/// </summary>
	[Command(ProtocolName.Accessibility.GetAXNode)]
	[SupportedBy("Chrome-Tip")]
	public class GetAXNodeCommand
	{
		/// <summary>
		/// Gets or sets ID of node to get accessibility node for.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long NodeId { get; set; }
	}
}
