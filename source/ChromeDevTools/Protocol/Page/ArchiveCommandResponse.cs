using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Grab an archive of the page.
	/// </summary>
	[CommandResponse(ProtocolName.Page.Archive)]
	[SupportedBy("iOS-9.3")]
	public class ArchiveCommandResponse
	{
		/// <summary>
		/// Gets or sets Base64-encoded web archive.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public string Data { get; set; }
	}
}
