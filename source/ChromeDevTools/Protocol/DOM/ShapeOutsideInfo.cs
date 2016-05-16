using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.DOM
{
	/// <summary>
	/// CSS Shape Outside details.
	/// </summary>
	[SupportedBy("Chrome-Tip")]
	public class ShapeOutsideInfo
	{
		/// <summary>
		/// Gets or sets Shape bounds
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public double[] Bounds { get; set; }
		/// <summary>
		/// Gets or sets Shape coordinate details
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public object[] Shape { get; set; }
		/// <summary>
		/// Gets or sets Margin shape bounds
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public object[] MarginShape { get; set; }
	}
}
