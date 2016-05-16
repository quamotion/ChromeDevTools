using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Network
{
	/// <summary>
	/// Loads a resource in the context of a frame on the inspected page without cross origin checks.
	/// </summary>
	[Command(ProtocolName.Network.LoadResource)]
	[SupportedBy("iOS-9.3")]
	public class LoadResourceCommand
	{
		/// <summary>
		/// Gets or sets Frame to load the resource from.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public string FrameId { get; set; }
		/// <summary>
		/// Gets or sets URL of the resource to load.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public string Url { get; set; }
	}
}
