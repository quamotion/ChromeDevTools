using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Capture a snapshot of the specified node that does not include unrelated layers.
	/// </summary>
	[Command(ProtocolName.Page.SnapshotNode)]
	[SupportedBy("iOS-9.3")]
	public class SnapshotNodeCommand
	{
		/// <summary>
		/// Gets or sets Id of the node to snapshot.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public long NodeId { get; set; }
	}
}
