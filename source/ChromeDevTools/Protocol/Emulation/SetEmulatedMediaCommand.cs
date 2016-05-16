using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Emulation
{
	/// <summary>
	/// Emulates the given media for CSS media queries.
	/// </summary>
	[Command(ProtocolName.Emulation.SetEmulatedMedia)]
	[SupportedBy("Chrome-Tip")]
	public class SetEmulatedMediaCommand
	{
		/// <summary>
		/// Gets or sets Media type to emulate. Empty string disables the override.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Media { get; set; }
	}
}
