using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.LayerTree
{
	/// <summary>
	/// Replays the layer snapshot and returns canvas log.
	/// </summary>
	[CommandResponse(ProtocolName.LayerTree.SnapshotCommandLog)]
	[SupportedBy("Chrome-Tip")]
	public class SnapshotCommandLogCommandResponse
	{
		public class CommandLogArray
		{
		}

		/// <summary>
		/// Gets or sets The array of canvas function calls.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public CommandLogArray[] CommandLog { get; set; }
	}
}
