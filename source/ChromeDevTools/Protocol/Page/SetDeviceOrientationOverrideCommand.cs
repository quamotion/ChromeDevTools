using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Page
{
	/// <summary>
	/// Overrides the Device Orientation.
	/// </summary>
	[Command(ProtocolName.Page.SetDeviceOrientationOverride)]
	[SupportedBy("Chrome-Tip")]
	public class SetDeviceOrientationOverrideCommand
	{
		/// <summary>
		/// Gets or sets Mock alpha
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public double Alpha { get; set; }
		/// <summary>
		/// Gets or sets Mock beta
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public double Beta { get; set; }
		/// <summary>
		/// Gets or sets Mock gamma
		/// </summary>
		[SupportedBy("Chrome-Tip")]
		public double Gamma { get; set; }
	}
}
