using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Rendering
{
	/// <summary>
	/// Requests that backend shows scroll bottleneck rects
	/// </summary>
	[Command(ProtocolName.Rendering.SetShowScrollBottleneckRects)]
	[SupportedBy("Chrome-Tip")]
	public class SetShowScrollBottleneckRectsCommand
	{
		/// <summary>
		/// Gets or sets True for showing scroll bottleneck rects
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public bool Show { get; set; }
	}
}
