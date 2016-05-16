using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// A structure holding an RGBA color.
	/// </summary>
	[SupportedBy("iOS-9.3")]
	public class RGBAColor
	{
		/// <summary>
		/// Gets or sets The red component, in the [0-255] range.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public long R { get; set; }
		/// <summary>
		/// Gets or sets The green component, in the [0-255] range.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public long G { get; set; }
		/// <summary>
		/// Gets or sets The blue component, in the [0-255] range.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public long B { get; set; }
		/// <summary>
		/// Gets or sets The alpha component, in the [0-1] range (default: 1).
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public double A { get; set; }
	}
}
