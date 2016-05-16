using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Focuses the given element.
	/// </summary>
	[Command(ProtocolName.DOM.Focus)]
	[SupportedBy("Chrome-Tip")]
	public class FocusCommand
	{
		/// <summary>
		/// Gets or sets Id of the node to focus.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long NodeId { get; set; }
	}
}
