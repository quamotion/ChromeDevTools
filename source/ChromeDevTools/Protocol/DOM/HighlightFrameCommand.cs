using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Highlights owner element of the frame with given id.
	/// </summary>
	[Command(ProtocolName.DOM.HighlightFrame)]
	[SupportedBy("Chrome-Tip")]
	public class HighlightFrameCommand
	{
		/// <summary>
		/// Gets or sets Identifier of the frame to highlight.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string FrameId { get; set; }
		/// <summary>
		/// Gets or sets The content box highlight fill color (default: transparent).
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public RGBA ContentColor { get; set; }
		/// <summary>
		/// Gets or sets The content box highlight outline color (default: transparent).
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public RGBA ContentOutlineColor { get; set; }
	}
}
