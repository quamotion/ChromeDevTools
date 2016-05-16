using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Returns present frame / resource tree structure.
	/// </summary>
	[CommandResponse(ProtocolName.Page.GetResourceTree)]
	[SupportedBy("Chrome-Tip")]
	public class GetResourceTreeCommandResponse
	{
		/// <summary>
		/// Gets or sets Present frame / resource tree structure.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public FrameResourceTree FrameTree { get; set; }
	}
}
