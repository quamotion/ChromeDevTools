using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Acknowledges that a screencast frame has been received by the frontend.
	/// </summary>
	[Command(ProtocolName.Page.ScreencastFrameAck)]
	[SupportedBy("Chrome-Tip")]
	public class ScreencastFrameAckCommand
	{
		/// <summary>
		/// Gets or sets Frame number.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public long FrameNumber { get; set; }
	}
}
