using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Input
{
	/// <summary>
	/// Synthesizes a tap gesture over a time period by issuing appropriate touch events.
	/// </summary>
	[Command(ProtocolName.Input.SynthesizeTapGesture)]
	[SupportedBy("Chrome-Tip")]
	public class SynthesizeTapGestureCommand
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
		/// Gets or sets Duration between touchdown and touchup events in ms (default: 50).
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long Duration { get; set; }
		/// <summary>
		/// Gets or sets Number of times to perform the tap (e.g. 2 for double tap, default: 1).
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long TapCount { get; set; }
		/// <summary>
		/// Gets or sets Which type of input events to be generated (default: 'default', which queries the platform for the preferred input type).
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string GestureSourceType { get; set; }
	}
}
