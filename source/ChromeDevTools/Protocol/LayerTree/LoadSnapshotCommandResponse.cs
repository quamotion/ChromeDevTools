using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.LayerTree
{
	/// <summary>
	/// Returns the snapshot identifier.
	/// </summary>
	[CommandResponse(ProtocolName.LayerTree.LoadSnapshot)]
	[SupportedBy("Chrome-Tip")]
	public class LoadSnapshotCommandResponse
	{
		/// <summary>
		/// Gets or sets The id of the snapshot.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string SnapshotId { get; set; }
	}
}
