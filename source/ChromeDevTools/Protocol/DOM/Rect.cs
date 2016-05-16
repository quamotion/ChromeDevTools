using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Rectangle.
	/// </summary>
	[SupportedBy("Chrome-Tip")]
	public class Rect
	{
		/// <summary>
		/// Gets or sets X coordinate
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public double X { get; set; }
		/// <summary>
		/// Gets or sets Y coordinate
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public double Y { get; set; }
		/// <summary>
		/// Gets or sets Rectangle width
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public double Width { get; set; }
		/// <summary>
		/// Gets or sets Rectangle height
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public double Height { get; set; }
	}
}
