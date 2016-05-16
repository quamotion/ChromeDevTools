using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.LayerTree
{
	/// <summary>
	/// A rectangle.
	/// </summary>
	[SupportedBy("iOS-9.3")]
	public class IntRect
	{
		/// <summary>
		/// Gets or sets The x position.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public long X { get; set; }
		/// <summary>
		/// Gets or sets The y position.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public long Y { get; set; }
		/// <summary>
		/// Gets or sets The width metric.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public long Width { get; set; }
		/// <summary>
		/// Gets or sets The height metric.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public long Height { get; set; }
	}
}
