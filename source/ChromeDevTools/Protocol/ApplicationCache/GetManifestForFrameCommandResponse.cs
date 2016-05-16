using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.ApplicationCache
{
	/// <summary>
	/// Returns manifest URL for document in the given frame.
	/// </summary>
	[CommandResponse(ProtocolName.ApplicationCache.GetManifestForFrame)]
	[SupportedBy("Chrome-Tip")]
	[SupportedBy("iOS-9.3")]
	public class GetManifestForFrameCommandResponse
	{
		/// <summary>
		/// Gets or sets Manifest URL for document in the given frame.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		[SupportedBy("iOS-9.3")]
		public string ManifestURL { get; set; }
	}
}
