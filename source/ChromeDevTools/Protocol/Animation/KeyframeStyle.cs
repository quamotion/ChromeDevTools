using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Animation
{
	/// <summary>
	/// Keyframe Style
	/// </summary>
	[SupportedBy("Chrome-Tip")]
	public class KeyframeStyle
	{
		/// <summary>
		/// Gets or sets Keyframe's time offset.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Offset { get; set; }
		/// <summary>
		/// Gets or sets <code>AnimationNode</code>'s timing function.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Easing { get; set; }
	}
}
