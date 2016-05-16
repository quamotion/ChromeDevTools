using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// Box model.
	/// </summary>
	[SupportedBy("Chrome-Tip")]
	public class BoxModel
	{
		/// <summary>
		/// Gets or sets Content box
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public double[] Content { get; set; }
		/// <summary>
		/// Gets or sets Padding box
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public double[] Padding { get; set; }
		/// <summary>
		/// Gets or sets Border box
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public double[] Border { get; set; }
		/// <summary>
		/// Gets or sets Margin box
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public double[] Margin { get; set; }
		/// <summary>
		/// Gets or sets Node width
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long Width { get; set; }
		/// <summary>
		/// Gets or sets Node height
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long Height { get; set; }
		/// <summary>
		/// Gets or sets Shape outside coordinates
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public ShapeOutsideInfo ShapeOutside { get; set; }
	}
}
