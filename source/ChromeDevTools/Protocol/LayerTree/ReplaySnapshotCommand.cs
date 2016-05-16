using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.LayerTree
{
	/// <summary>
	/// Replays the layer snapshot and returns the resulting bitmap.
	/// </summary>
	[Command(ProtocolName.LayerTree.ReplaySnapshot)]
	[SupportedBy("Chrome-Tip")]
	public class ReplaySnapshotCommand
	{
		/// <summary>
		/// Gets or sets The id of the layer snapshot.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string SnapshotId { get; set; }
		/// <summary>
		/// Gets or sets The first step to replay from (replay from the very start if not specified).
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long FromStep { get; set; }
		/// <summary>
		/// Gets or sets The last step to replay to (replay till the end if not specified).
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long ToStep { get; set; }
		/// <summary>
		/// Gets or sets The scale to apply while replaying (defaults to 1).
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public double Scale { get; set; }
	}
}
