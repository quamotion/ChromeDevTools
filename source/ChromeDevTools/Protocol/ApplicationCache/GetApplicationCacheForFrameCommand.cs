using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.ApplicationCache
{
	/// <summary>
	/// Returns relevant application cache data for the document in given frame.
	/// </summary>
	[Command(ProtocolName.ApplicationCache.GetApplicationCacheForFrame)]
	[SupportedBy("Chrome-Tip")]
	public class GetApplicationCacheForFrameCommand
	{
		/// <summary>
		/// Gets or sets Identifier of the frame containing document whose application cache is retrieved.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string FrameId { get; set; }
	}
}
