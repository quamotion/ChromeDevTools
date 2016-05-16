using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.LayerTree
{
	/// <summary>
	/// Returns the layer tree structure of the current page.
	/// </summary>
	[Command(ProtocolName.LayerTree.LayersForNode)]
	[SupportedBy("iOS-9.3")]
	public class LayersForNodeCommand
	{
		/// <summary>
		/// Gets or sets Root of the subtree for which we want to gather layers.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public long NodeId { get; set; }
	}
}
