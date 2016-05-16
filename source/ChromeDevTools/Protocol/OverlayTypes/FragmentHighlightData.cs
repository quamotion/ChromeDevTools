using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.OverlayTypes
{
	/// <summary>
	/// Data required to highlight multiple quads.
	/// </summary>
	[SupportedBy("iOS-9.3")]
	public class FragmentHighlightData
	{
		/// <summary>
		/// Gets or sets Quads for which the highlight should be applied.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public Point[][] Quads { get; set; }
		/// <summary>
		/// Gets or sets ContentColor
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public string ContentColor { get; set; }
		/// <summary>
		/// Gets or sets ContentOutlineColor
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public string ContentOutlineColor { get; set; }
		/// <summary>
		/// Gets or sets PaddingColor
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public string PaddingColor { get; set; }
		/// <summary>
		/// Gets or sets BorderColor
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public string BorderColor { get; set; }
		/// <summary>
		/// Gets or sets MarginColor
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public string MarginColor { get; set; }
		/// <summary>
		/// Gets or sets RegionClippingArea
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public Point[] RegionClippingArea { get; set; }
	}
}
