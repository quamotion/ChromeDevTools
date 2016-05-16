using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.LayerTree
{
	/// <summary>
	/// Replays the layer snapshot and returns the resulting bitmap.
	/// </summary>
	[CommandResponse(ProtocolName.LayerTree.ReplaySnapshot)]
	[SupportedBy("Chrome-Tip")]
	public class ReplaySnapshotCommandResponse
	{
		/// <summary>
		/// Gets or sets A data: URL for resulting image.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string DataURL { get; set; }
	}
}
