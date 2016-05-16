using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Screencast frame metadata
	/// </summary>
	[SupportedBy("Chrome-Tip")]
	public class ScreencastFrameMetadata
	{
		/// <summary>
		/// Gets or sets Top offset in DIP.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public double OffsetTop { get; set; }
		/// <summary>
		/// Gets or sets Page scale factor.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public double PageScaleFactor { get; set; }
		/// <summary>
		/// Gets or sets Device screen width in DIP.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public double DeviceWidth { get; set; }
		/// <summary>
		/// Gets or sets Device screen height in DIP.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public double DeviceHeight { get; set; }
		/// <summary>
		/// Gets or sets Position of horizontal scroll in CSS pixels.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public double ScrollOffsetX { get; set; }
		/// <summary>
		/// Gets or sets Position of vertical scroll in CSS pixels.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public double ScrollOffsetY { get; set; }
		/// <summary>
		/// Gets or sets Frame swap timestamp.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public double Timestamp { get; set; }
	}
}
