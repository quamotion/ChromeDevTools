using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Highlights given quad. Coordinates are absolute with respect to the main frame viewport.
	/// </summary>
	[Command(ProtocolName.DOM.HighlightQuad)]
	[SupportedBy("Chrome-Tip")]
	public class HighlightQuadCommand
	{
		/// <summary>
		/// Gets or sets Quad to highlight
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		[SupportedBy("iOS-9.3")]
		public double[] Quad { get; set; }
		/// <summary>
		/// Gets or sets The highlight fill color (default: transparent).
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		[SupportedBy("iOS-9.3")]
		public RGBA Color { get; set; }
		/// <summary>
		/// Gets or sets The highlight outline color (default: transparent).
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		[SupportedBy("iOS-9.3")]
		public RGBA OutlineColor { get; set; }
		/// <summary>
		/// Gets or sets Indicates whether the provided parameters are in page coordinates or in viewport coordinates (the default).
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public bool UsePageCoordinates { get; set; }
	}
}
