using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.LayerTree
{
	/// <summary>
	/// Returns the layer snapshot identifier.
	/// </summary>
	[CommandResponse(ProtocolName.LayerTree.MakeSnapshot)]
	[SupportedBy("Chrome-Tip")]
	public class MakeSnapshotCommandResponse
	{
		/// <summary>
		/// Gets or sets The id of the layer snapshot.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string SnapshotId { get; set; }
	}
}
