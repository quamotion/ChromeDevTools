using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Animation
{
	/// <summary>
	/// AnimationPlayer instance.
	/// </summary>
	[SupportedBy("Chrome-Tip")]
	public class AnimationPlayer
	{
		/// <summary>
		/// Gets or sets <code>AnimationPlayer</code>'s id.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Id { get; set; }
		/// <summary>
		/// Gets or sets <code>AnimationPlayer</code>'s internal paused state.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public bool PausedState { get; set; }
		/// <summary>
		/// Gets or sets <code>AnimationPlayer</code>'s play state.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string PlayState { get; set; }
		/// <summary>
		/// Gets or sets <code>AnimationPlayer</code>'s playback rate.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public double PlaybackRate { get; set; }
		/// <summary>
		/// Gets or sets <code>AnimationPlayer</code>'s start time.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public double StartTime { get; set; }
		/// <summary>
		/// Gets or sets <code>AnimationPlayer</code>'s current time.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public double CurrentTime { get; set; }
		/// <summary>
		/// Gets or sets <code>AnimationPlayer</code>'s source animation node.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public AnimationNode Source { get; set; }
		/// <summary>
		/// Gets or sets Animation type of <code>AnimationPlayer</code>.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Type { get; set; }
	}
}
