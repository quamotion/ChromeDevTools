using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Returns content of the given resource.
	/// </summary>
	[Command(ProtocolName.Page.GetResourceContent)]
	[SupportedBy("Chrome-Tip")]
	public class GetResourceContentCommand
	{
		/// <summary>
		/// Gets or sets Frame id to get resource for.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string FrameId { get; set; }
		/// <summary>
		/// Gets or sets URL of the resource to get content for.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Url { get; set; }
	}
}
