using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.LayerTree
{
	/// <summary>
	/// Provides the reasons why the given layer was composited.
	/// </summary>
	[Command(ProtocolName.LayerTree.ReasonsForCompositingLayer)]
	[SupportedBy("iOS-9.3")]
	public class ReasonsForCompositingLayerCommand
	{
		/// <summary>
		/// Gets or sets The id of the layer for which we want to get the reasons it was composited.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public string LayerId { get; set; }
	}
}
