using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Returns node id at given location.
	/// </summary>
	[Command(ProtocolName.DOM.GetNodeForLocation)]
	[SupportedBy("Chrome-Tip")]
	public class GetNodeForLocationCommand
	{
		/// <summary>
		/// Gets or sets X coordinate.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long X { get; set; }
		/// <summary>
		/// Gets or sets Y coordinate.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long Y { get; set; }
	}
}
