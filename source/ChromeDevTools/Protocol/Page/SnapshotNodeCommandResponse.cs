using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Capture a snapshot of the specified node that does not include unrelated layers.
	/// </summary>
	[CommandResponse(ProtocolName.Page.SnapshotNode)]
	[SupportedBy("iOS-9.3")]
	public class SnapshotNodeCommandResponse
	{
		/// <summary>
		/// Gets or sets Base64-encoded image data (PNG).
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public string DataURL { get; set; }
	}
}
