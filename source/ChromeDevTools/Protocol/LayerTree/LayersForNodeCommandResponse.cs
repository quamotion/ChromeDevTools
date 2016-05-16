using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.LayerTree
{
	/// <summary>
	/// Returns the layer tree structure of the current page.
	/// </summary>
	[CommandResponse(ProtocolName.LayerTree.LayersForNode)]
	[SupportedBy("iOS-9.3")]
	public class LayersForNodeCommandResponse
	{
		/// <summary>
		/// Gets or sets Child layers.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public Layer[] Layers { get; set; }
	}
}
