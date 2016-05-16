using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.Timeline
{
	/// <summary>
	/// Fired when recording has stopped.
	/// </summary>
	[Event(ProtocolName.Timeline.RecordingStopped)]
	[SupportedBy("iOS-9.3")]
	public class RecordingStoppedEvent
	{
		/// <summary>
		/// Gets or sets End time of this recording.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public double EndTime { get; set; }
	}
}
