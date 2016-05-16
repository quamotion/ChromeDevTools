using MasterDevs.ChromeDevTools;

namespace MasterDevs.ChromeDevTools.Protocol.Animation
{
	/// <summary>
	/// Event for each animation player that has been created.
	/// </summary>
	[Event(ProtocolName.Animation.AnimationPlayerCreated)]
	[SupportedBy("Chrome-Tip")]
	public class AnimationPlayerCreatedEvent
	{
		/// <summary>
		/// Gets or sets AnimationPlayer that was created.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public AnimationPlayer Player { get; set; }
		/// <summary>
		/// Gets or sets Whether the timeline should be reset.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public bool ResetTimeline { get; set; }
	}
}
