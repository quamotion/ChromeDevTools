using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.LayerTree
{
	/// <summary>
	/// Returns the snapshot identifier.
	/// </summary>
	[Command(ProtocolName.LayerTree.LoadSnapshot)]
	[SupportedBy("Chrome-Tip")]
	public class LoadSnapshotCommand
	{
		/// <summary>
		/// Gets or sets An array of tiles composing the snapshot.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public PictureTile[] Tiles { get; set; }
	}
}
