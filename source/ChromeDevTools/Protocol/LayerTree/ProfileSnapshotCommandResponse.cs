using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.LayerTree
{
	[CommandResponse(ProtocolName.LayerTree.ProfileSnapshot)]
	[SupportedBy("Chrome-Tip")]
	public class ProfileSnapshotCommandResponse
	{
		/// <summary>
		/// Gets or sets The array of paint profiles, one per run.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public double[][] Timings { get; set; }
	}
}
