using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Emulation
{
	/// <summary>
	/// Toggles mouse event-based touch event emulation.
	/// </summary>
	[Command(ProtocolName.Emulation.SetTouchEmulationEnabled)]
	[SupportedBy("Chrome-Tip")]
	public class SetTouchEmulationEnabledCommand
	{
		/// <summary>
		/// Gets or sets Whether the touch event emulation should be enabled.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public bool Enabled { get; set; }
		/// <summary>
		/// Gets or sets Touch/gesture events configuration. Default: current platform.
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public string Configuration { get; set; }
	}
}
