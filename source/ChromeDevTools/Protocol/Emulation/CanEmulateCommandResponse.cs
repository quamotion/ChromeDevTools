using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Emulation
{
	/// <summary>
	/// Tells whether emulation is supported.
	/// </summary>
	[CommandResponse(ProtocolName.Emulation.CanEmulate)]
	[SupportedBy("Chrome-Tip")]
	public class CanEmulateCommandResponse
	{
		/// <summary>
		/// Gets or sets True if emulation is supported.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public bool Result { get; set; }
	}
}
