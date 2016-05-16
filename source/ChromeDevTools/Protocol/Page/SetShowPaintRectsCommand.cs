using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Requests that backend shows paint rectangles
	/// </summary>
	[Command(ProtocolName.Page.SetShowPaintRects)]
	[SupportedBy("iOS-9.3")]
	public class SetShowPaintRectsCommand
	{
		/// <summary>
		/// Gets or sets True for showing paint rectangles
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public bool Result { get; set; }
	}
}
