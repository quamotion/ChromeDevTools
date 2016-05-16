using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Input
{
	/// <summary>
	/// Synthesizes a scroll gesture over a time period by issuing appropriate touch events.
	/// </summary>
	[Command(ProtocolName.Input.SynthesizeScrollGesture)]
	[SupportedBy("Chrome-Tip")]
	public class SynthesizeScrollGestureCommand
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
		/// Gets or sets The distance to scroll along the X axis (positive to scroll left).
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long XDistance { get; set; }
		/// <summary>
		/// Gets or sets The distance to scroll along the Y axis (positive to scroll up).
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long YDistance { get; set; }
		/// <summary>
		/// Gets or sets The number of additional pixels to scroll back along the X axis, in addition to the given distance.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long XOverscroll { get; set; }
		/// <summary>
		/// Gets or sets The number of additional pixels to scroll back along the Y axis, in addition to the given distance.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long YOverscroll { get; set; }
		/// <summary>
		/// Gets or sets Prevent fling (default: true).
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public bool PreventFling { get; set; }
		/// <summary>
		/// Gets or sets Swipe speed in pixels per second (default: 800).
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long Speed { get; set; }
		/// <summary>
		/// Gets or sets Which type of input events to be generated (default: 'default', which queries the platform for the preferred input type).
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string GestureSourceType { get; set; }
	}
}
