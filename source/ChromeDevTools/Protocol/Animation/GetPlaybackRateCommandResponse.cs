using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Animation
{
	/// <summary>
	/// Gets the playback rate of the document timeline.
	/// </summary>
	[CommandResponse(ProtocolName.Animation.GetPlaybackRate)]
	[SupportedBy("Chrome-Tip")]
	public class GetPlaybackRateCommandResponse
	{
		/// <summary>
		/// Gets or sets Playback rate for animations on page.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public double PlaybackRate { get; set; }
	}
}
