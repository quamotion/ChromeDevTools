using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.ApplicationCache
{
	/// <summary>
	/// Returns manifest URL for document in the given frame.
	/// </summary>
	[Command(ProtocolName.ApplicationCache.GetManifestForFrame)]
	[SupportedBy("Chrome-Tip")]
	public class GetManifestForFrameCommand
	{
		/// <summary>
		/// Gets or sets Identifier of the frame containing document whose manifest is retrieved.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string FrameId { get; set; }
	}
}
