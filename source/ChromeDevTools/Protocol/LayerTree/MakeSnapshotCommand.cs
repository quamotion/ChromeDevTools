using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.LayerTree
{
	/// <summary>
	/// Returns the layer snapshot identifier.
	/// </summary>
	[Command(ProtocolName.LayerTree.MakeSnapshot)]
	[SupportedBy("Chrome-Tip")]
	public class MakeSnapshotCommand
	{
		/// <summary>
		/// Gets or sets The id of the layer.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string LayerId { get; set; }
	}
}
