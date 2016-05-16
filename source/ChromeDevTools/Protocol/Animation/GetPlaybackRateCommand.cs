using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Animation
{
	/// <summary>
	/// Gets the playback rate of the document timeline.
	/// </summary>
	[Command(ProtocolName.Animation.GetPlaybackRate)]
	[SupportedBy("Chrome-Tip")]
	public class GetPlaybackRateCommand
	{
	}
}
