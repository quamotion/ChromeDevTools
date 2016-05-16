using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Animation
{
	/// <summary>
	/// AnimationNode instance
	/// </summary>
	[SupportedBy("Chrome-Tip")]
	public class AnimationNode
	{
		/// <summary>
		/// Gets or sets <code>AnimationNode</code>'s delay.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public double Delay { get; set; }
		/// <summary>
		/// Gets or sets <code>AnimationNode</code>'s end delay.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public double EndDelay { get; set; }
		/// <summary>
		/// Gets or sets <code>AnimationNode</code>'s playbackRate.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public double PlaybackRate { get; set; }
		/// <summary>
		/// Gets or sets <code>AnimationNode</code>'s iteration start.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public double IterationStart { get; set; }
		/// <summary>
		/// Gets or sets <code>AnimationNode</code>'s iterations.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public double Iterations { get; set; }
		/// <summary>
		/// Gets or sets <code>AnimationNode</code>'s iteration duration.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public double Duration { get; set; }
		/// <summary>
		/// Gets or sets <code>AnimationNode</code>'s playback direction.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Direction { get; set; }
		/// <summary>
		/// Gets or sets <code>AnimationNode</code>'s fill mode.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Fill { get; set; }
		/// <summary>
		/// Gets or sets <code>AnimationNode</code>'s name.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Name { get; set; }
		/// <summary>
		/// Gets or sets <code>AnimationNode</code>'s target node.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long BackendNodeId { get; set; }
		/// <summary>
		/// Gets or sets <code>AnimationNode</code>'s keyframes.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public KeyframesRule KeyframesRule { get; set; }
		/// <summary>
		/// Gets or sets <code>AnimationNode</code>'s timing function.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Easing { get; set; }
	}
}
