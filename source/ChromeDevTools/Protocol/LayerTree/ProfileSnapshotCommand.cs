using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.LayerTree
{
	[Command(ProtocolName.LayerTree.ProfileSnapshot)]
	[SupportedBy("Chrome-Tip")]
	public class ProfileSnapshotCommand
	{
		/// <summary>
		/// Gets or sets The id of the layer snapshot.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string SnapshotId { get; set; }
		/// <summary>
		/// Gets or sets The maximum number of times to replay the snapshot (1, if not specified).
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long MinRepeatCount { get; set; }
		/// <summary>
		/// Gets or sets The minimum duration (in seconds) to replay the snapshot.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public double MinDuration { get; set; }
		/// <summary>
		/// Gets or sets The clip rectangle to apply when replaying the snapshot.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public DOM.Rect ClipRect { get; set; }
	}
}
