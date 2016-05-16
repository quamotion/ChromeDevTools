using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Animation
{
	/// <summary>
	/// Keyframes Rule
	/// </summary>
	[SupportedBy("Chrome-Tip")]
	public class KeyframesRule
	{
		/// <summary>
		/// Gets or sets CSS keyframed animation's name.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Name { get; set; }
		/// <summary>
		/// Gets or sets List of animation keyframes.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public KeyframeStyle[] Keyframes { get; set; }
	}
}
