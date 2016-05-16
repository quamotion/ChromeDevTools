using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.OverlayTypes
{
	/// <summary>
	/// Data required to configure the overlay's size and scaling behavior.
	/// </summary>
	[SupportedBy("iOS-9.3")]
	public class OverlayConfiguration
	{
		/// <summary>
		/// Gets or sets DeviceScaleFactor
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public double DeviceScaleFactor { get; set; }
		/// <summary>
		/// Gets or sets ViewportSize
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public Size ViewportSize { get; set; }
		/// <summary>
		/// Gets or sets FrameViewFullSize
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public Size FrameViewFullSize { get; set; }
	}
}
