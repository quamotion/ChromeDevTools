using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.LayerTree
{
	/// <summary>
	/// Provides the reasons why the given layer was composited.
	/// </summary>
	[CommandResponse(ProtocolName.LayerTree.ReasonsForCompositingLayer)]
	[SupportedBy("iOS-9.3")]
	public class ReasonsForCompositingLayerCommandResponse
	{
		/// <summary>
		/// Gets or sets An object containing the reasons why the layer was composited as properties.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public CompositingReasons CompositingReasons { get; set; }
	}
}
