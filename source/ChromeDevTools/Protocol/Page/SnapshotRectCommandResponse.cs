using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Capture a snapshot of the page within the specified rectangle and coordinate system.
	/// </summary>
	[CommandResponse(ProtocolName.Page.SnapshotRect)]
	[SupportedBy("iOS-9.3")]
	public class SnapshotRectCommandResponse
	{
		/// <summary>
		/// Gets or sets Base64-encoded image data (PNG).
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public string DataURL { get; set; }
	}
}
