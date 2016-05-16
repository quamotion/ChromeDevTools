using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Network
{
	/// <summary>
	/// Loads a resource in the context of a frame on the inspected page without cross origin checks.
	/// </summary>
	[CommandResponse(ProtocolName.Network.LoadResource)]
	[SupportedBy("iOS-9.3")]
	public class LoadResourceCommandResponse
	{
		/// <summary>
		/// Gets or sets Resource content.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public string Content { get; set; }
		/// <summary>
		/// Gets or sets Resource mimeType.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public string MimeType { get; set; }
		/// <summary>
		/// Gets or sets HTTP response status code.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public double Status { get; set; }
	}
}
