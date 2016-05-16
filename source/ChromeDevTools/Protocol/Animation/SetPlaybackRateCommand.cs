using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Animation
{
	/// <summary>
	/// Sets the playback rate of the document timeline.
	/// </summary>
	[Command(ProtocolName.Animation.SetPlaybackRate)]
	[SupportedBy("Chrome-Tip")]
	public class SetPlaybackRateCommand
	{
		/// <summary>
		/// Gets or sets Playback rate for animations on page
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public double PlaybackRate { get; set; }
	}
}
