using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Debugger
{
	/// <summary>
	/// Sets overlay message.
	/// </summary>
	[Command(ProtocolName.Debugger.SetOverlayMessage)]
	[SupportedBy("iOS-9.3")]
	public class SetOverlayMessageCommand
	{
		/// <summary>
		/// Gets or sets Overlay message to display when paused in debugger.
		/// </summary>
		[SupportedBy("iOS-9.3")]
		public string Message { get; set; }
	}
}
