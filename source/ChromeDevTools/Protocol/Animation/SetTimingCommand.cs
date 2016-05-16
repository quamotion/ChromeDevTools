using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Animation
{
	/// <summary>
	/// Sets the timing of an animation node.
	/// </summary>
	[Command(ProtocolName.Animation.SetTiming)]
	[SupportedBy("Chrome-Tip")]
	public class SetTimingCommand
	{
		/// <summary>
		/// Gets or sets AnimationPlayer id.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string PlayerId { get; set; }
		/// <summary>
		/// Gets or sets Duration of the animation.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public double Duration { get; set; }
		/// <summary>
		/// Gets or sets Delay of the animation.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public double Delay { get; set; }
	}
}
