using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.OverlayTypes
{
	/// <summary>
	/// A rectangle specified by a reference coordinate and width/height offsets.
	/// </summary>
	[SupportedBy("iOS-9.3")]
	public class Rect
	{
		/// <summary>
		/// Gets or sets X
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public double X { get; set; }
		/// <summary>
		/// Gets or sets Y
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public double Y { get; set; }
		/// <summary>
		/// Gets or sets Width
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public double Width { get; set; }
		/// <summary>
		/// Gets or sets Height
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public double Height { get; set; }
	}
}
