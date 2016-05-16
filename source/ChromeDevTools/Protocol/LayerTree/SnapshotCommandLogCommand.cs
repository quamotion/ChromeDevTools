using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.LayerTree
{
	/// <summary>
	/// Replays the layer snapshot and returns canvas log.
	/// </summary>
	[Command(ProtocolName.LayerTree.SnapshotCommandLog)]
	[SupportedBy("Chrome-Tip")]
	public class SnapshotCommandLogCommand
	{
		/// <summary>
		/// Gets or sets The id of the layer snapshot.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string SnapshotId { get; set; }
	}
}
