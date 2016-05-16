using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Timeline
{
	/// <summary>
	/// Timeline record contains information about the recorded activity.
	/// </summary>
	[SupportedBy("Chrome-Tip")]
	public class TimelineEvent
	{
		/// <summary>
		/// Gets or sets Event type.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Type { get; set; }
		/// <summary>
		/// Gets or sets Event data.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public object Data { get; set; }
		/// <summary>
		/// Gets or sets Start time.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public double StartTime { get; set; }
		/// <summary>
		/// Gets or sets End time.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public double EndTime { get; set; }
		/// <summary>
		/// Gets or sets Nested records.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public TimelineEvent[] Children { get; set; }
		/// <summary>
		/// Gets or sets If present, identifies the thread that produced the event.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Thread { get; set; }
		/// <summary>
		/// Gets or sets Stack trace.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public Console.CallFrame[] StackTrace { get; set; }
		/// <summary>
		/// Gets or sets Unique identifier of the frame within the page that the event relates to.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string FrameId { get; set; }
	}
}
