using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.LayerTree
{
	/// <summary>
	/// Releases layer snapshot captured by the back-end.
	/// </summary>
	[Command(ProtocolName.LayerTree.ReleaseSnapshot)]
	[SupportedBy("Chrome-Tip")]
	public class ReleaseSnapshotCommand
	{
		/// <summary>
		/// Gets or sets The id of the layer snapshot.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string SnapshotId { get; set; }
	}
}
