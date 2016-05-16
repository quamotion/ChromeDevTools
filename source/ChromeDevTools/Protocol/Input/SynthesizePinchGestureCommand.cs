using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Input
{
	/// <summary>
	/// Synthesizes a pinch gesture over a time period by issuing appropriate touch events.
	/// </summary>
	[Command(ProtocolName.Input.SynthesizePinchGesture)]
	[SupportedBy("Chrome-Tip")]
	public class SynthesizePinchGestureCommand
	{
		/// <summary>
		/// Gets or sets X coordinate of the start of the gesture in CSS pixels.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long X { get; set; }
		/// <summary>
		/// Gets or sets Y coordinate of the start of the gesture in CSS pixels.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long Y { get; set; }
		/// <summary>
		/// Gets or sets Relative scale factor after zooming (>1.0 zooms in, <1.0 zooms out).
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public double ScaleFactor { get; set; }
		/// <summary>
		/// Gets or sets Relative pointer speed in pixels per second (default: 800).
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long RelativeSpeed { get; set; }
		/// <summary>
		/// Gets or sets Which type of input events to be generated (default: 'default', which queries the platform for the preferred input type).
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string GestureSourceType { get; set; }
	}
}
