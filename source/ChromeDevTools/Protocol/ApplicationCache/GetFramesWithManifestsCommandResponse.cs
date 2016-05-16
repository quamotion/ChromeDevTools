using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.ApplicationCache
{
	/// <summary>
	/// Returns array of frame identifiers with manifest urls for each frame containing a document associated with some application cache.
	/// </summary>
	[CommandResponse(ProtocolName.ApplicationCache.GetFramesWithManifests)]
	[SupportedBy("Chrome-Tip")]
	public class GetFramesWithManifestsCommandResponse
	{
		/// <summary>
		/// Gets or sets Array of frame identifiers with manifest urls for each frame containing a document associated with some application cache.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public FrameWithManifest[] FrameIds { get; set; }
	}
}
