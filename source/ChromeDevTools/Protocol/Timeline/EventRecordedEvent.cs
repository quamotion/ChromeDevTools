using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.Timeline
{
	/// <summary>
	/// Deprecated.
	/// </summary>
	[Event(ProtocolName.Timeline.EventRecorded)]
	[SupportedBy("Chrome-Tip")]
	public class EventRecordedEvent
	{
		/// <summary>
		/// Gets or sets Timeline event record data.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public TimelineEvent Record { get; set; }
	}
}
