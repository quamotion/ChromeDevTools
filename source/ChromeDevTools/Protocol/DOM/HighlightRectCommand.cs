using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Highlights given rectangle. Coordinates are absolute with respect to the main frame viewport.
	/// </summary>
	[Command(ProtocolName.DOM.HighlightRect)]
	[SupportedBy("Chrome-Tip")]
	public class HighlightRectCommand
	{
		/// <summary>
		/// Gets or sets X coordinate
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		[SupportedBy("iOS-9.3")]
		public long X { get; set; }
		/// <summary>
		/// Gets or sets Y coordinate
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		[SupportedBy("iOS-9.3")]
		public long Y { get; set; }
		/// <summary>
		/// Gets or sets Rectangle width
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		[SupportedBy("iOS-9.3")]
		public long Width { get; set; }
		/// <summary>
		/// Gets or sets Rectangle height
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		[SupportedBy("iOS-9.3")]
		public long Height { get; set; }
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
