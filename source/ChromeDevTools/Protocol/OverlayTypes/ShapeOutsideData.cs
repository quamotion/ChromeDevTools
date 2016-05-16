using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.OverlayTypes
{
	/// <summary>
	/// 
	/// </summary>
	[SupportedBy("iOS-9.3")]
	public class ShapeOutsideData
	{
		/// <summary>
		/// Gets or sets Bounds for the shape-outside paths.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public Point[] Bounds { get; set; }
		/// <summary>
		/// Gets or sets Path for the element's shape.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public object[] Shape { get; set; }
		/// <summary>
		/// Gets or sets Path for the element's margin shape.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public object[] MarginShape { get; set; }
	}
}
