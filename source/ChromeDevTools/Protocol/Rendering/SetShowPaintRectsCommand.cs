using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Rendering
{
	/// <summary>
	/// Requests that backend shows paint rectangles
	/// </summary>
	[Command(ProtocolName.Rendering.SetShowPaintRects)]
	[SupportedBy("Chrome-Tip")]
	public class SetShowPaintRectsCommand
	{
		/// <summary>
		/// Gets or sets True for showing paint rectangles
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public bool Result { get; set; }
	}
}
