using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.Timeline
{
	/// <summary>
	/// Fired when recording has started.
	/// </summary>
	[Event(ProtocolName.Timeline.RecordingStarted)]
	[SupportedBy("iOS-9.3")]
	public class RecordingStartedEvent
	{
		/// <summary>
		/// Gets or sets Start time of this new recording.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public double StartTime { get; set; }
	}
}
