using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Input
{
	/// <summary>
	/// 
	/// </summary>
	[SupportedBy("Chrome-Tip")]
	public class TouchPoint
	{
		/// <summary>
		/// Gets or sets State of the touch point.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string State { get; set; }
		/// <summary>
		/// Gets or sets X coordinate of the event relative to the main frame's viewport.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long X { get; set; }
		/// <summary>
		/// Gets or sets Y coordinate of the event relative to the main frame's viewport. 0 refers to the top of the viewport and Y increases as it proceeds towards the bottom of the viewport.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long Y { get; set; }
		/// <summary>
		/// Gets or sets X radius of the touch area (default: 1).
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long RadiusX { get; set; }
		/// <summary>
		/// Gets or sets Y radius of the touch area (default: 1).
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long RadiusY { get; set; }
		/// <summary>
		/// Gets or sets Rotation angle (default: 0.0).
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public double RotationAngle { get; set; }
		/// <summary>
		/// Gets or sets Force (default: 1.0).
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public double Force { get; set; }
		/// <summary>
		/// Gets or sets Identifier used to track touch sources between events, must be unique within an event.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public double Id { get; set; }
	}
}
